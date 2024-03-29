﻿using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        public ActionResult Index()
        {
            var listaCatalogo = new List<Catalogo>();
            var item1 = new Catalogo();
            item1.Titulo = "Mulher Maravilha";
            item1.Sinopse = "Um grande filme sobre uma mulher maravilhosa!!!";
            item1.Duracao = 157;
            item1.Diretor = "Joao Adubal";
            item1.AnoLancamento = "2018";
            item1.Imagem = "../Images/mulhermaravilha.jfif";


            listaCatalogo.Add(item1);


          
            var item2 = new Catalogo();
            item2.Titulo = "Doutor Estranho";
            item2.Sinopse = "Vivia estranhamente, o que sonhava Dr.Estranho?";
            item2.Duracao = 207;
            item2.Diretor = "Manuel Castro";
            item2.AnoLancamento = "2010";
            item2.Imagem = "/Images/doutorestranho.jfif";
            

            listaCatalogo.Add(item2);


            var item3 = new Catalogo();
            item3.Titulo = "Guardiões da Galaxia";
            item3.Sinopse = "Não brinque em serviço ou aprenda isso!";
            item3.Duracao = 300;
            item3.Diretor = "Joao Adubal Filho";
            item3.AnoLancamento = "2018";
            item3.Imagem = "/Images/guardiaodagalaxia.jfif";

            listaCatalogo.Add(item3);


            return View(listaCatalogo);
        }

 


        // GET: Catalogo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalogo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalogo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalogo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
