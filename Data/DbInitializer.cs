using AuthorsBookCatalogue.Models;

namespace AuthorsBookCatalogue.Data
{
    public class DbInitializer
    {
        public static void Initialize(BookStoreContext context)
        {
            // Look for any Books.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }
            //10 BOOKS 
            Book book1 = new Book { Title = "Outlive: The Science and Art of Longevity", DateCreated = new DateTime(2023, 03, 28), Publisher = "Random House Audio", BookType = "Audio", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/41qWDt1FuBL.jpg", Dimensions = "17 hrs 7 mins", Rating = 5 };
            Book book2 = new Book { Title = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", DateCreated = new DateTime(2018, 08, 16), Publisher = "Penguin Audio", BookType = "Audio", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/513Y5o-DYtL.jpg", Dimensions = "5hrs 35 mins", Rating = 4 };
            Book book3 = new Book { Title = "Spare", DateCreated = new DateTime(2023, 01, 01), Publisher = "Random House Audio", BookType = "Audio", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/41hYQIILU3L.jpg", Dimensions = "15 hrs 39 mins", Rating = 5 };
            Book book4 = new Book { Title = "The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life", DateCreated = new DateTime(2016, 09, 13), Publisher = "Harper", BookType = "Pdf", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/51mN3bY0JjL.jpg", Dimensions = "-", Rating = 4 };
            Book book5 = new Book { Title = "The 48 Laws of Power", DateCreated = new DateTime(2000, 09, 01), Publisher = "Penguin Books", BookType = "Pdf", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/41EhEN9nsmL.jpg", Dimensions = "-", Rating = 5 };
            Book book6 = new Book { Title = "Life Worth Living: A Guide to What Matters Most Hardcover", DateCreated = new DateTime(2023, 03, 28), Publisher = "The Open Field", BookType = "Paperback", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/415vSeNOQPL._SX329_BO1,204,203,200_.jpg", Dimensions = ".77 x 1.17 x 8.54 inches", Rating = 4 };
            Book book7 = new Book { Title = "The Body Keeps the Score: Brain, Mind, and Body in the Healing of Trauma", DateCreated = new DateTime(2014, 09, 25), Publisher = "Penguin Books", BookType = "Pdf", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/41DFLjSxhKL.jpg", Dimensions = "-", Rating = 5 };
            Book book8 = new Book { Title = "Can't Hurt Me: Master Your Mind and Defy the Odds", DateCreated = new DateTime(2020, 12, 04), Publisher = "Lioncrest Publishing", BookType = "Pdf", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/41amV20d1uL.jpg", Dimensions = "-", Rating = 4 };
            Book book9 = new Book { Title = "The Creative Act: A Way of Being Hardcover", DateCreated = new DateTime(2023, 01, 17), Publisher = "Penguin Press", BookType = "Paperback", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/41AkIg2fDcL._SX339_BO1,204,203,200_.jpg", Dimensions = "6.25 x 1.29 x 8.75 inches", Rating = 5 };
            Book book10 = new Book { Title = "The Love Stories of the Bible Speak: Biblical Lessons on Romance, Friendship, and Faith", DateCreated = new DateTime(2023, 03, 28), Publisher = "Broadside Books", BookType = "Paperback", Language = "English", ImageUrl = "https://m.media-amazon.com/images/I/51AhZ+jvGyL._SY344_BO1,204,203,200_.jpg", Dimensions = "5.5 x 1.01 x 8.25 inches", Rating = 5 };

            //10 AUTHORS
            Author author1 = new Author { Name = "Peter Attia MD", About = "Peter Attia, MD, is the founder of Early Medical, a medical practice that applies the principles of Medicine 3.0 to patients with the goal of lengthening their lifespan and simultaneously improving their healthspan.", ImageUrl = "https://peterattiamd.com/wp-content/uploads/2020/06/Peter-Attia-C57A2508-Square.jpg" };
            Author author2 = new Author { Name = "James Clear", About = "I’m the author of the #1 New York Times bestseller, Atomic Habits, which has sold more than 15 million copies worldwide. My work has been featured in places like Time magazine, the New York Times, the Wall Street Journal and on CBS This Morning.", ImageUrl = "https://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSbQDpMtXVuO_W38yiLY2XXsHBcMnxEJtBwmdfP5TVs2O_aJALybAlxMt9QvCsd01h_" };
            Author author3 = new Author { Name = "Prince Harry The Duke of Sussex", About = "Prince Harry, Duke of Sussex, KCVO is a member of the British royal family. He is the younger son of King Charles III and Diana, Princess of Wales. He is fifth in the line of succession to the British throne. Harry was educated at Wetherby School, Ludgrove School, and Eton College.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/32/Lancering_Invictus_Games_2020-7_%28cropped%29.jpg" };
            Author author4 = new Author { Name = "Mark Manson", About = "Mark Manson is the #1 New York Times Bestselling author of Everything is F*cked: A Book About Hope and The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life, the mega-bestseller that reached #1 in fourteen different countries.", ImageUrl = "https://m.media-amazon.com/images/S/amzn-author-media-prod/ppppnrtb11dqtjikkq5carfg90._SY600_.jpg" };
            Author author5 = new Author { Name = "Robert Greene", About = "Robert Greene is the author of the New York Times bestsellers The 48 Laws of Power, The Art of Seduction, The 33 Strategies of War, and The 50th Law.", ImageUrl = "https://m.media-amazon.com/images/S/amzn-author-media-prod/eaepvmifn1s1moomieu0q7pia7._SY600_.jpg" };
            Author author6 = new Author { Name = "Miroslav Volf", About = "Miroslav Volf is the Henry B. Wright Professor of Theology at Yale Divinity School and Director of the Yale Center for Faith & Culture. He has published and edited nine books and over 60 scholarly articles, including his book Exclusion and Embrace, which won the 2002 Grawemeyer Award in Religion.", ImageUrl = "https://m.media-amazon.com/images/I/41Opy5DyRlL._SY600_.jpg" };
            Author author7 = new Author { Name = "Bessel van der Kolk", About = "Bessel van der Kolk (born 1943) is a Boston based psychiatrist noted for his research in the area of post-traumatic stress since the 1970s. His work focuses on the interaction of attachment, neurobiology, and developmental aspects of trauma’s effects on people.", ImageUrl = "https://m.media-amazon.com/images/S/amzn-author-media-prod/126pafdtmhtn6sn3idroaecn16._SY1438_CR0%2C0%2C1438%2C1438_.jpg" };
            Author author8 = new Author { Name = "David Goggins", About = "David Goggins is a Retired Navy SEAL and the only member of the U.S. Armed Forces to complete SEAL training, Army Ranger School, and Air Force Tactical Air Controller training. Goggins has completed more than seventy ultra-distance races, often placing in the top five, and is a former Guinness World Record holder for completing 4,030 pull-ups in seventeen hours.", ImageUrl = "https://m.media-amazon.com/images/S/amzn-author-media-prod/73kvrao1t3fmfgit79ne3dsu5v._SY600_.jpg" };
            Author author9 = new Author { Name = "Rick Rubin", About = "Frederick Jay \"Rick\" Rubin is an American record executive and record producer. He is a co-founder of Def Jam Recordings, founder of American Recordings, and former co-president of Columbia Records.", ImageUrl = "https://m.media-amazon.com/images/S/amzn-author-media-prod/3q514se0bbefkr5n8rtkh5a0bm._SY600_.jpg" };
            Author author10 = new Author { Name = "Shannon Bream", About = "SHANNON BREAM joined Fox News Channel in 2007. She currently serves as host of Fox News @ Night (weekdays at 11 p.m.), the network’s Chief Legal Correspondent. She is a magna cum laude graduate of Liberty University, a former Miss America finalist and earned a Juris Doctorate with honors from Florida State University College of Law.", ImageUrl = "https://m.media-amazon.com/images/S/amzn-author-media-prod/9o3dfurf6g1m6pfhohn1eurr9s._SY600_.jpg" };

            //ADD BOOKS TO AUTHOR'S and VICE VERSA + ADD ALL TO DATABASE TABLES
            // --> books first
            book1.Authors.Add(author1); book2.Authors.Add(author2); book3.Authors.Add(author3); book4.Authors.Add(author4); book5.Authors.Add(author5);
            book6.Authors.Add(author6); book7.Authors.Add(author7); book8.Authors.Add(author8); book9.Authors.Add(author9); book10.Authors.Add(author10);
            context.Books.AddRange(book1); context.Books.AddRange(book2); context.Books.AddRange(book3); context.Books.AddRange(book4); context.Books.AddRange(book5);
            context.Books.AddRange(book6); context.Books.AddRange(book7); context.Books.AddRange(book8); context.Books.AddRange(book9); context.Books.AddRange(book10);
            context.SaveChanges();
            // --> authors next
            //author1.Books.Add(book1); author2.Books.Add(book2); author3.Books.Add(book3); author4.Books.Add(book4); author5.Books.Add(book5); author1.Books.Add(book2);
            //author6.Books.Add(book6); author7.Books.Add(book7); author8.Books.Add(book8); author9.Books.Add(book9); author10.Books.Add(book10);
            //context.Authors.AddRange(author1);context.Authors.AddRange(author2);context.Authors.AddRange(author3); context.Authors.AddRange(author4); context.Authors.AddRange(author5);
            //context.Authors.AddRange(author6); context.Authors.AddRange(author7); context.Authors.AddRange(author8); context.Authors.AddRange(author9); context.Authors.AddRange(author10);
            //context.SaveChanges();

        }
    }
}
