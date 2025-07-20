using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using GetNPCPos.Level5.Image;
using GetNPCPos.Level5.Archive.XPCK;
using GetNPCPos.Level5.Binary;

namespace GetNPCPos
{
    public partial class GetNPCPos : Form
    {
        public string MapPath;

        int[] BoundariesBox;

        private Point _currentMousePosition = Point.Empty;
        private Point _currentArrowPosition = Point.Empty; // Current position for arrow navigation

        // List to store saved points
        private List<Point> _savedPoints = new List<Point>();

        public GetNPCPos()
        {
            InitializeComponent();
            UpdateButtonStates();

            // Allow the control to receive focus for keyboard events
            this.KeyPreview = true;
            pictureBox1.TabStop = true;
            pictureBox1.Focus();
        }

        private static Point NPCPointToMiniMapPoint(int[] boundaries, float pointX, float pointY, int mapWidth, int mapHeight)
        {
            int minX = boundaries[0];
            int minY = boundaries[1];
            int maxX = boundaries[2];
            int maxY = boundaries[3];

            int rangeX = maxX - minX;
            int rangeY = maxY - minY;

            double scaleX = (double)mapWidth / rangeX;
            double scaleY = (double)mapHeight / rangeY;

            int mapX = (int)((pointX - minX) * scaleX);
            int mapY = (int)((pointY - minY) * scaleY);

            return new Point(mapX, mapY);
        }

        private static Point MiniMapPointToNPCPoint(int[] boundaries, int mapX, int mapY, int mapWidth, int mapHeight)
        {
            int minX = boundaries[0];
            int minY = boundaries[1];
            int maxX = boundaries[2];
            int maxY = boundaries[3];

            int rangeX = maxX - minX;
            int rangeY = maxY - minY;

            double scaleX = (double)mapWidth / rangeX;
            double scaleY = (double)mapHeight / rangeY;

            float pointX = (float)(mapX / scaleX + minX);
            float pointY = (float)(mapY / scaleY + minY);

            return new Point((int)pointX, (int)pointY);
        }

        private void OpenMap(string mapPath)
        {
            // Check if there is mini map image
            string imagePath = $"{MapPath}/{Path.GetFileName(mapPath)}.xi";
            if (File.Exists(imagePath))
            {
                (Bitmap, int, int) imageData = IMGC.ToBitmap(File.ReadAllBytes(imagePath));
                pictureBox1.Image = imageData.Item1;
                pictureBox1.Width = imageData.Item2;
                pictureBox1.Height = imageData.Item3;
                pictureBox1.Enabled = true;

                // Initialize arrow position to center of image
                _currentArrowPosition = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);

                // Update UI with initial arrow position
                UpdateUIWithPosition(_currentArrowPosition);
            }

            byte[] mapenByteArray = null;

            // Check if there is mapenv file
            string mapenvPath = $"{MapPath}/{Path.GetFileName(mapPath)}_mapenv.bin";
            if (File.Exists(mapenvPath))
            {
                mapenByteArray = File.ReadAllBytes(mapenvPath);
            }
            else
            {
                // Try to search on the maven xpck
                string xpckPath = $"{MapPath}/mapenv.pck";
                if (File.Exists(xpckPath))
                {

                    XPCK mapenvXPCK = new XPCK(File.ReadAllBytes(xpckPath));

                    if (mapenvXPCK.Directory.Files.ContainsKey($"{Path.GetFileName(mapPath)}_mapenv.bin"))
                    {
                        mapenByteArray = mapenvXPCK.Directory.GetFileFromFullPath($"/{Path.GetFileName(mapPath)}_mapenv.bin");
                    }
                }
            }

            if (mapenByteArray != null)
            {
                CfgBin mapenvBin = new CfgBin();
                mapenvBin.Open(mapenByteArray);

                BoundariesBox = mapenvBin.GetPtreeValue("MMModelPos").ToArray();
            }

            numericUpDownMapPositionX.Enabled = true;
            numericUpDownMapPositionY.Enabled = true;

            if (BoundariesBox.Length > 0)
            {
                numericUpDownNPCPositionX.Enabled = true;
                numericUpDownNPCPositionY.Enabled = true;
            }
        }

        // Method to update UI controls with a given position
        private void UpdateUIWithPosition(Point position)
        {
            numericUpDownMapPositionX.Value = position.X;
            numericUpDownMapPositionY.Value = position.Y;

            if (BoundariesBox != null)
            {
                Point npcPos = MiniMapPointToNPCPoint(BoundariesBox, position.X, position.Y, pictureBox1.Width, pictureBox1.Height);
                label1.Text = $"MapPos: {position.X};{position.Y} / NPCPos: {npcPos.X};{npcPos.Y}";

                numericUpDownNPCPositionX.Value = npcPos.X;
                numericUpDownNPCPositionY.Value = npcPos.Y;
            }
            else
            {
                label1.Text = $"MapPos: {position.X};{position.Y}";
            }

            if (label1.Visible == false)
            {
                label1.Visible = true;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog romfsOpenFileDialog = new CommonOpenFileDialog();
            romfsOpenFileDialog.Title = "Select map path";
            romfsOpenFileDialog.IsFolderPicker = true;

            if (romfsOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MapPath = romfsOpenFileDialog.FileName;
                BoundariesBox = null;
                OpenMap(MapPath);
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point imagePos = pictureBox1.PointToClient(Cursor.Position);
            UpdateUIWithPosition(imagePos);
            _currentMousePosition = e.Location;
            pictureBox1.Invalidate();
        }

        // Method to handle click in PictureBox
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Point clickPoint = e.Location;

                // Add point to list
                _savedPoints.Add(clickPoint);

                // Add point to ListView
                ListViewItem item = new ListViewItem($"Point {_savedPoints.Count}");
                item.SubItems.Add($"({clickPoint.X}; {clickPoint.Y})");
                item.Tag = clickPoint;
                listView1.Items.Add(item);

                // Update button states
                UpdateButtonStates();

                // Redraw PictureBox
                pictureBox1.Invalidate();
            }
        }

        // Handle keyboard events for arrow navigation
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (pictureBox1.Image != null)
            {
                bool moved = false;
                Point newPosition = _currentArrowPosition;

                switch (keyData)
                {
                    case Keys.Up:
                        if (newPosition.Y > 0)
                        {
                            newPosition.Y -= 1;
                            moved = true;
                        }
                        break;
                    case Keys.Down:
                        if (newPosition.Y < pictureBox1.Height - 1)
                        {
                            newPosition.Y += 1;
                            moved = true;
                        }
                        break;
                    case Keys.Left:
                        if (newPosition.X > 0)
                        {
                            newPosition.X -= 1;
                            moved = true;
                        }
                        break;
                    case Keys.Right:
                        if (newPosition.X < pictureBox1.Width - 1)
                        {
                            newPosition.X += 1;
                            moved = true;
                        }
                        break;
                    case Keys.Enter:
                        // Add point at current arrow position
                        if (_currentArrowPosition != Point.Empty)
                        {
                            _savedPoints.Add(_currentArrowPosition);

                            ListViewItem item = new ListViewItem($"Point {_savedPoints.Count}");
                            item.SubItems.Add(_currentArrowPosition.X.ToString());
                            item.SubItems.Add(_currentArrowPosition.Y.ToString());
                            item.Tag = _currentArrowPosition;
                            listView1.Items.Add(item);

                            UpdateButtonStates();
                            pictureBox1.Invalidate();
                        }
                        return true;
                }

                if (moved)
                {
                    _currentArrowPosition = newPosition;
                    UpdateUIWithPosition(_currentArrowPosition);
                    pictureBox1.Invalidate();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Handle click on PictureBox to set arrow position
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MouseEventArgs me = e as MouseEventArgs;
                if (me != null)
                {
                    _currentArrowPosition = me.Location;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Draw mouse hover point (red)
            if (_currentMousePosition != Point.Empty)
            {
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillEllipse(brush, _currentMousePosition.X - 2, _currentMousePosition.Y - 2, 5, 5);
                }
            }

            // Draw current arrow position (green)
            if (_currentArrowPosition != Point.Empty && pictureBox1.Image != null)
            {
                using (SolidBrush arrowBrush = new SolidBrush(Color.Green))
                {
                    e.Graphics.FillEllipse(arrowBrush, _currentArrowPosition.X - 3, _currentArrowPosition.Y - 3, 6, 6);
                }

                // Draw small square around for better visualization
                using (Pen arrowPen = new Pen(Color.Green, 2))
                {
                    e.Graphics.DrawRectangle(arrowPen, _currentArrowPosition.X - 5, _currentArrowPosition.Y - 5, 10, 10);
                }
            }

            // Draw all saved points (blue by default, yellow if selected)
            for (int i = 0; i < _savedPoints.Count; i++)
            {
                Point point = _savedPoints[i];
                Color pointColor = Color.Blue;

                // Check if this point is selected in ListView
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    Point selectedPoint = (Point)selectedItem.Tag;
                    if (point == selectedPoint)
                    {
                        pointColor = Color.Yellow;
                    }
                }

                using (SolidBrush savedBrush = new SolidBrush(pointColor))
                {
                    e.Graphics.FillEllipse(savedBrush, point.X - 3, point.Y - 3, 6, 6);
                }

                // Optional: display point number
                using (Font font = new Font("Arial", 8))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    e.Graphics.DrawString((i + 1).ToString(), font, textBrush, point.X - 5, point.Y - 15);
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update UI when a point is selected in ListView
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Point selectedPoint = (Point)selectedItem.Tag;

                // Update UI controls with selected point position
                UpdateUIWithPosition(selectedPoint);
            }

            UpdateButtonStates();
            pictureBox1.Invalidate(); // Redraw to update selected point color
        }

        private void ButtonDeleteCurrentPoint_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Point pointToRemove = (Point)selectedItem.Tag;

                // Find and remove point from list
                int index = _savedPoints.IndexOf(pointToRemove);
                if (index >= 0)
                {
                    _savedPoints.RemoveAt(index);
                }

                // Remove item from ListView
                listView1.Items.Remove(selectedItem);

                // Renumber remaining items in ListView
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].Text = $"Point {i + 1}";
                }

                // Update button states
                UpdateButtonStates();

                // Redraw PictureBox
                pictureBox1.Invalidate();
            }
        }

        private void ButtonDeleteAllPoint_Click(object sender, EventArgs e)
        {
            // Clear points list
            _savedPoints.Clear();

            // Clear ListView
            listView1.Items.Clear();

            // Update button states
            UpdateButtonStates();

            // Redraw PictureBox
            pictureBox1.Invalidate();
        }

        // Method to update button states
        private void UpdateButtonStates()
        {
            // "Delete Current Point" button is enabled only if a point is selected
            buttonDeleteCurrentPoint.Enabled = listView1.SelectedItems.Count > 0;

            // "Delete All Points" button is enabled only if there are points
            buttonDeleteAllPoint.Enabled = _savedPoints.Count > 0;
        }
    }
}