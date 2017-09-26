using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Defines the types of tiles we can have
public enum TileType { Empty, Floor };

// Defines which each square of our world 'grid' is
public class Tile {

	// The X and Y coordinate of the tile
	public int x { get; protected set; }
	public int y { get; protected set; }

	private TileType _type = TileType.Empty;
	public TileType tileType {
		get { return _type; }
		set { _type = value;
			// Need to use callback to notify of tile change
		}
	}

	// Does the tile contain furniture?
	//FIXME: Create furniture class
	public Furniture furn { get; protected set; }

	// Does this tile contain inventory?
	//FIXME: Create inventory class
	Inventory inv;

	public Tile(int x, int y){
		this.x = x;
		this.y = y;
	}
}
