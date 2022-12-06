using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022
{
    class Game
    {
        // Properties
        public string saveName = "default";

        static private string rootPath
        {
            get
            {
                return Directory.GetCurrentDirectory() + "\\saves\\";
            }
        }

        // Get all folder names in rootPath folder
        static public string[] saves
        {
            get
            {
                // Get full path of all folders in rootPath
                string[] paths = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);

                // Remove rootPath from paths
                for (int i = 0; i < paths.Length; i++)
                    paths[i] = paths[i].Replace(rootPath, "");

                return paths;
            }
        }

        private string savePath
        {
            get
            {
                return rootPath + this.saveName + "\\";
            }
        }

        
        // Constructor
        public Game(string saveName)
        {
            this.saveName = saveName;
        }

        
        public void CreateSave()
        {
            CreateFolder();
        }

        
        private void CreateFolder()
        {
            Console.WriteLine("Creating folder in " + this.savePath);
            System.IO.Directory.CreateDirectory(this.savePath);
        }

    }
}
