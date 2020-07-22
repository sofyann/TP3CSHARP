using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChatMetier.Database;
using ChatMetier.Entities;

namespace Chat.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            FakeDb fakeDb = FakeDb.Instance;
            List<ChatMetier.Entities.Chat> chats = fakeDb.GetAll();
            return View(chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            FakeDb fakeDb = FakeDb.Instance;
            ChatMetier.Entities.Chat chat = fakeDb.Get(id);
            if (chat == null)
            {
                //throw new HttpNotFoundResult();
            }
            return View(chat);
        }

        // GET: Chat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chat/Create
        [HttpPost]
        public ActionResult Create(ChatMetier.Entities.Chat chat)
        {
            try
            {
                FakeDb fakeDb = FakeDb.Instance;
                fakeDb.Create(chat);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chat/Edit/5
        public ActionResult Edit(int id)
        {
            FakeDb fakeDb = FakeDb.Instance;
            ChatMetier.Entities.Chat chat = fakeDb.Get(id);
            if (chat == null)
            {
                //throw new HttpNotFoundResult();
            }
            return View(chat);
        }

        // POST: Chat/Edit/5
        [HttpPost]
        public ActionResult Edit(ChatMetier.Entities.Chat chat)
        {
            try
            {
                FakeDb fakeDb = FakeDb.Instance;
                fakeDb.Edit(chat);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            FakeDb fakeDb = FakeDb.Instance;
            ChatMetier.Entities.Chat chat = fakeDb.Get(id);
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                FakeDb fakeDb = FakeDb.Instance;
                fakeDb.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
