# GetNPCPos
Converting minimap coordinates to real NPC positions in Level-5 games

## Tested Games

- ✅ **Inazuma Eleven Go Light & Shadow** (Nintendo 3DS)

### File Structure Expected

The tool expects the following file structure in your selected map folder:

```
MapFolder/
├── [mapname].xi           # Minimap image file
├── [mapname]_mapenv.bin   # Map environment file (optional)
└── mapenv.pck            # XPCK archive containing mapenv files (optional)
```

## Usage

### Getting Started

1. **Load Map Data**:
   - Click on "Open"
   - Select the folder containing your map files
   - The tool will automatically load the minimap image (.xi file) and boundary data

2. **Navigate the Map**:
   - **Mouse**: Hover over the minimap to see coordinates in real-time
   - **Arrow Keys**: Use ↑↓←→ for precise pixel-by-pixel navigation
   - **Click**: Click anywhere to set the arrow cursor position

3. **Save Points**:
   - **Mouse**: Click on the minimap to save a point
   - **Keyboard**: Press Enter while using arrow navigation to save current position
   - Saved points appear in the list on the right side

4. **Manage Points**:
   - Select points from the list to highlight them in yellow
   - Use "Delete Current Point" to remove selected point
   - Use "Delete All Points" to clear all saved points

### Coordinate Systems

- **MapPos**: Pixel coordinates on the minimap image (0,0 = top-left)
- **NPCPos**: Real-world game coordinates for NPC placement

The conversion between these coordinate systems is handled automatically using boundary data from the mapenv files.
