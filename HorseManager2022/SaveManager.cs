using HorseManager2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022
{

    static public class SaveManager
    {
        static string PATH = Game.playerPath; // replace with actual path
        static string DELIMITER = ";"; // replace with actual delimiter


        static private T GetInstance<T>(string itemStr) where T : IDefinable => (T)Activator.CreateInstance(typeof(T), new object[] { itemStr })!;


        static public T? Get<T>(int id) where T : IDefinable
        {
            string[] lines = File.ReadAllLines(PATH);

            for (int i = 0; i < lines.Length; i++)
            {
                T _item = GetInstance<T>(lines[i]);

                if (_item.id == id)
                    return _item;
            }

            return default;
        }


        static public List<T> Get<T>() where T : IDefinable
        {
            string[] lines = File.ReadAllLines(PATH);
            List<T> items = new();

            foreach (string itemStr in lines)
            {
                items.Add(GetInstance<T>(itemStr));
            }

            return items;
        }


        static public void Add<T>(T item) where T : IDefinable
        {
            item.id = GetAutoIncrementId<T>();
            string itemStr = item.ToSaveFormat();

            File.AppendAllText(PATH, itemStr + Environment.NewLine);
        }


        static public void Update<T>(T item) where T : IDefinable
        {
            string[] lines = File.ReadAllLines(PATH);

            for (int i = 0; i < lines.Length; i++)
            {
                T _item = GetInstance<T>(lines[i]);

                if (_item.id == item.id)
                {
                    lines[i] = item.ToSaveFormat();
                }
            }

            File.WriteAllLines(PATH, lines);
        }


        static private int GetAutoIncrementId<T>() where T : IDefinable
        {
            string[] lines = File.ReadAllLines(PATH);
            string itemStr = lines.Last();
            T item = GetInstance<T>(itemStr);
            return item.id + 1;
        }
    }
}