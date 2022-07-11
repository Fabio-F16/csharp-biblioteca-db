﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace csharp_biblioteca_db
{
    internal class Biblioteca
    {
        List<Utente> nuoviUtenti;
        List<Documento> documenti;


        public Biblioteca()
        {
            nuoviUtenti = new List<Utente>();
            documenti = new List<Documento>();
        }

        public void AggiungiUtente(Utente utente)
        {
            this.nuoviUtenti.Add(utente);
        }

        public void AggiungiDocumento(Documento documento)
        {
            this.documenti.Add(documento);
        }

        internal void StampaDocumento()
        {
            Console.WriteLine("Lista articoli:");
            Console.WriteLine();
            foreach (Documento documento in this.documenti)
            {
                Console.WriteLine(documento.GetType().Name);
                Console.WriteLine(documento.ToString());
            }
        }
        internal void StampaUtenti()
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Fabioz\\Documents\\db-biblioteca.mdf;Integrated Security=True;Connect Timeout=30");

            conn.Open();

            string query = "SELECT name, surname, email FROM users";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("--------------------");
            Console.WriteLine("Lista utenti:");
            Console.WriteLine("Nome\tCognome\tEmail");

            while (reader.Read()) { 

                Console.WriteLine("{0}\t{1}\t{2}", reader.GetString(0), reader.GetString(1), reader.GetString(2));
    
                Console.WriteLine();
            }
            reader.Close();
        }

        public void Login()
        {
           Biblioteca biblioteca = new Biblioteca();
            
            Console.WriteLine("Inserisci il tuo nome");
            string nome = Console.ReadLine();
           

            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine();
            

            Console.WriteLine("Inserisci la tua email");
            string email = Console.ReadLine();
            Utente tempUtente = new Utente(nome, cognome, email);

           
            Console.WriteLine("Utente registrato");
            
            
        }

        public void Registrazione()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Fabioz\\Documents\\db-biblioteca.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                string query = "INSERT INTO users (name, surname, email) VALUES (@nome, @cognome, @email)";
                SqlCommand cmd = new SqlCommand(query, conn);

                Console.WriteLine("Inserisci i dati per registrarti");
                Console.WriteLine();
                Console.WriteLine("Inserisci il tuo nome");
                string nome = Console.ReadLine();
                cmd.Parameters.Add(new SqlParameter("@nome", nome));

                Console.WriteLine("Inserisci il tuo cognome");
                string cognome = Console.ReadLine();
                cmd.Parameters.Add(new SqlParameter("@cognome", cognome));

                Console.WriteLine("Inserisci la tua email");
                string email = Console.ReadLine();
                cmd.Parameters.Add(new SqlParameter("@email", email));

                Utente nuovoUtente = new Utente(nome, cognome, email);
                this.nuoviUtenti.Add(nuovoUtente);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void addPrestito()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Fabioz\\Documents\\db-biblioteca.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                string query = "INSERT INTO rents (start, end, user_id, copy_id) value (@start, @end, @userId, @copyId)";
                SqlCommand command = new SqlCommand(query, conn);
                Console.WriteLine("Inserisci i dati per l'avvio del prestito: ");
                Console.WriteLine();

                Console.WriteLine("Inserisci il tuo id User: ");
                string userId = Console.ReadLine();
                command.Parameters.Add(new SqlParameter("@userId", userId));

                Console.WriteLine("Inserisci l'id del libro: ");
                string copyId = Console.ReadLine();
                command.Parameters.Add(new SqlParameter("@copyId", copyId));

                Console.WriteLine("Inserisci la data di avvio del prestito: ");
                DateTime dataStart = System.DateTime.Parse(Console.ReadLine());
                command.Parameters.Add(new SqlParameter("@start", dataStart));

                Console.WriteLine("Inserisci la data di riconsegna: ");
                DateTime dataEnd = System.DateTime.Parse(Console.ReadLine());
                command.Parameters.Add(new SqlParameter("@end", dataEnd));

                command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }


           
        }

    }
}
