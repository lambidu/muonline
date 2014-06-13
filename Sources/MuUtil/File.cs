﻿using UnityEngine;
using System.Collections;

namespace Util {
	
	public class File {
		
		public static string	DIRECTORY_KEYS			= "Keys/";
		public static string	DIRECTORY_PLAYER		= "Player/";
		public static string	DIRECTORY_DATA			= "Data/";
		public static string	DIRECTORY_SOUND_AREA	= "Sound/Area/";
		public static string	DIRECTORY_SOUND_PLAYER	= "Sound/Player/";
		public static string	DIRECTORY_LANG			= "Languages/";
		public static string	DIRECTORY_LIGHTS		= "Lightmaps/World";
		public static string	DIRECTORY_MULTI			= "Interface/Multi/";
		public static string	DIRECTORY_MAPSLOGO		= "Interface/MapsLogo/";
		public static string	DIRECTORY_FONTS			= "Interface/Fonts/";
		
		
		//папка мира
		public static string WorldStorageDir ( Util.Map.Location map ) {
			string dir = "";
			int i = (int)map;
			if(i!=0) {
				dir = "World"+i.ToString();
			}
			return dir;
		}
		
		//папка объектов
		public static string ObjectsStorageDir ( Util.Map.Location map ) {
			string dir = "";
			int i = (int)map;
			if(i!=0) {
				dir = "Object"+i.ToString()+"/";
			}
			return dir;
		}
		
		//папка UI элементов с мультиязычностью
		public static string MultiUIDir(string name) {
			return Util.File.DIRECTORY_MULTI + Lang.GetLanguage() + "/" + name;
		}
		
		//папка тел
		public static string BodyStorageDir ( Util.Player.Class _class, string part ) {
			return Util.File.DIRECTORY_PLAYER + part + "Class" + ( Util.Player.IsSub( _class ) ? "2" : "" ) + Util.Data.IntToDoubleString ( Util.Player.GetClassInt ( _class ) );
		}
		
		//адрес локализированого xml
		public static string Localization() {
			return Util.File.DIRECTORY_LANG + Lang.GetLanguage().ToString() + "/strings";
		}
		
	}
	
}