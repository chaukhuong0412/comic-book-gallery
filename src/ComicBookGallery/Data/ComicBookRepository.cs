﻿using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                SeriesTitle = "Harry Potter",
                IssueNumber = 700,
                DescriptionHtml = "<p>Harry Potter is a wizzard abc xyz </p>",
                Artists = new Artist[] {
                new Artist() { Name = "Daniel", Role = "Harry"},
                new Artist() { Name = "Emma", Role = "Herminone"},
                new Artist() { Name = "Robert", Role = "Ron"}
                }
            },
            new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorite = false
            },
            new ComicBook()
            {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            }
        };

        public ComicBook getComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}