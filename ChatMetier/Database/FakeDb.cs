using ChatMetier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMetier.Database
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy = new Lazy<FakeDb>(() => new FakeDb());

        private int i = 1;

        public static FakeDb Instance { get { return lazy.Value; } }

        private List<Chat> chats;

        private FakeDb()
        {
            chats = new List<Chat>
            {
                new Chat{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new Chat{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new Chat{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new Chat{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new Chat{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new Chat{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new Chat{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }

        public List<Chat> GetAll()
        {
            return chats;
        }

        public Chat Get(int id)
        {
            return chats.Find(c => c.Id == id);
        }

        public void Delete(int id)
        {
            chats.Remove(Get(id));
        }

        public int Create(Chat chat)
        {
            chat.Id = i++;
            chats.Add(chat);
            return i;
        }

        public void Edit(Chat chat)
        {
            chats[chats.FindIndex(c => c.Id == chat.Id)] = chat;
        }
    }
}
