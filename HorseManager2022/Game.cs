using HorseManager2022.Models;
using HorseManager2022.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022
{
    internal class Game
    {
        // Properties
        public Player player;
        public Canvas canvas;
        public string saveName = "default";

        static private string rootPath
        {
            get
            {
                return Directory.GetCurrentDirectory() + "\\saves\\";
            }
        }

        private string savePath
        {
            get
            {
                return rootPath + this.saveName + "\\";
            }
        }

        // Get all folder names in rootPath folder
        static public string[] saves
        {
            get
            {
                string[] paths;
                
                try
                {
                    paths = Directory.GetDirectories(rootPath);
                }
                catch (Exception)
                {
                    Directory.CreateDirectory(rootPath);
                    paths = Directory.GetDirectories(rootPath);
                }

                // Remove rootPath from paths
                for (int i = 0; i < paths.Length; i++)
                    paths[i] = paths[i].Replace(rootPath, "");

                return paths;
            }
        }

        // Constructor
        public Game(Canvas canvas, string saveName, bool isNewSave = false)
        {
            this.saveName = saveName;
            this.canvas = canvas;

            if (isNewSave) 
                CreateSave();
            
            this.player = GetPlayer();
        }
        
        
        public void CreateSave()
        {
            CreateFolder();
            
            // Create all files
            CreateFile("player.txt");
            CreateFile("horses.txt");
            CreateFile("horseJockeys.txt");
            CreateFile("jockeys.txt");
            CreateFile("staff.txt");
            CreateFile("events.txt");

            // Create objects
            CreatePlayer(new Player(saveName, 10, new Date()));
        }


        public void DeleteSave() => Directory.Delete(this.savePath, true);

        private void CreateFolder() => Directory.CreateDirectory(this.savePath);

        private void CreateFile(string fileName)
        {
            using (StreamWriter sw = File.CreateText(this.savePath + fileName))
            {
                sw.Write("");
            }
        }
        

        /*
            Crud Methods for files
        */

        // Player [GET / POST / PUT / DELETE]
        
        public void CreatePlayer(Player player)
        {
            string path = this.savePath + "player.txt";

            // Add user to file
            File.AppendAllText(path, player.name + ";" + player.money + ";" + player.date.ToSaveFormat() + Environment.NewLine);
        }

        public Player GetPlayer()
        {
            string path = this.savePath + "player.txt";
            string[] data = File.ReadAllLines(path).First().Split(';');
            return new Player(data[0], int.Parse(data[1]), new Date(int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
        }

        public void UpdatePlayer(Player player)
        {
            string path = this.savePath + "player.txt";
            string[] lines = File.ReadAllLines(path);

            // Check if user already exists
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Split(";")[0] == player.name)
                {
                    lines[i] = player.name + ";" + player.money + ";" + player.date.ToSaveFormat();
                    File.WriteAllLines(path, lines);
                    return;
                }
            }

            throw new Exception("User does not exist");
        }

        // Horses [GET / POST / PUT / DELETE]
        /*
        public void CreateHorse(Horse horse)
        {
            string path = this.savePath + "horses.txt";
            string[] lines = File.ReadAllLines(path);

            // Check if horse already exists
            foreach (string line in lines)
            {
                if (line.Split(";")[0] == horse.name)
                    throw new Exception("Horse already exists");
            }

            // Add horse to file
            File.AppendAllText(path, horse.name + ";" + horse.age);
        }

        public Horse GetHorse(string name)
        {
            string path = this.savePath + "horses.txt";
            string[] lines = File.ReadAllLines(path);

            // Check if horse already exists
            foreach (string line in lines)
            {
                if (line.Split(";")[0] == name)
                {
                    string[] data = line.Split(";");
                    return new Horse(data[0], int.Parse(data[1]));
                }
            }

            throw new Exception("Horse does not exist");
        }

        public void UpdateHorse(Horse horse)
        {
            string path = this.savePath + "horses.txt";
            string[] lines = File.ReadAllLines(path);

            // Check if horse already exists
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Split(";")[0] == horse.name)
                {
                    lines[i] = horse.name + ";" + horse.age;
                    File.WriteAllLines(path, lines);
                    return;
                }
            }

            throw new Exception("Horse does not exist");
        }*/
    }
}
