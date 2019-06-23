﻿using eFastFood_PCL.Models;
using eFastFood_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace eFastFood
{
    public static class Global
    {
        public static Klijent prijavnjeniKorisnik { get; set; }
        public static List<NarudzbaStavka> stavkeNarudzbe { get; set; } = new List<NarudzbaStavka>();
        public static List<GotoviProizvod> proizvodi { get; set; }

        public static void AddToCart(int GotoviProizvodID, int Kolicina)
        {
            NarudzbaStavka ns = stavkeNarudzbe.Find(x => x.GotoviProizvodID == GotoviProizvodID);
            if (ns != null)
                stavkeNarudzbe.Find(x => x.GotoviProizvodID == GotoviProizvodID).Kolicina += 1;
            else
                stavkeNarudzbe.Add(new NarudzbaStavka()
                {
                    Kolicina = Kolicina,
                    GotoviProizvodID = GotoviProizvodID,
                });
        }
        public static void ChangeQuantityInCart(int GotoviProizvodID, int Kolicina)
        {
            NarudzbaStavka exist = stavkeNarudzbe.Find(x => x.GotoviProizvodID == GotoviProizvodID);
            if (exist != null)
                stavkeNarudzbe.Find(x => x.GotoviProizvodID == GotoviProizvodID).Kolicina = Kolicina;
        }

        #region API Route
        public static string ApiUrl = Application.Current.Resources["APIAddress"].ToString();


        public static string UposleniciRoute = "Uposlenik";
        public static string GotoviProizvodRoute = "GotoviProizvod";
        public static string KategorijaRoute = "Kategorija";
        public static string ProizvoidRoute = "Proizvod";
        public static string DobavljacRoute = "Dobavljac";
        public static string MjernaJedinicaRoute = "MjernaJedinica";
        public static string GPProizvodRoute = "GPProizvod";
        public static string KlijentRoute = "Klijent";
        public static string NarudzbeRoute = "Narudzba";
        public static string UlogeRoute = "Uloga";
        public static string DostavaRoute = "Dostava";

        #endregion
    }
}
