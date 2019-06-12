using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.TestData
{
    public class BookData
    {
        public IEnumerable<Book> Books() =>new List<Book>
        {
            new Book(1,"Niedźwiedź i pianino","Litchfield David",17.25m,"nip.jpg","Pewnego dnia młody niedźwiedź znajduje w lesie coś, czego nigdy wcześniej nie widział. Czas mija, a zwierzę powoli uczy się gry na przedziwnym instrumencie.",2019),
            new Book(2,"TumTum Dudniący słoń","Damiron Anya",21.82m,"TumTum Dudniący słoń.jpg","Żył sobie kiedyś słoń, który był duży. Był tak wielki, że prawie nie mógł chodzić. Tum! TUM! Jego kroki zawsze dudniły: Tum! TuUuM! TuUuM! TuUuM! I tak właśnie miał na imię: Tumtum.",2019),
            new Book(3,"Historia Pokolenia","Grzegorz Schetyna, Cezary Michalski",31.13m,"Historia Pokolenia.jpg","To pokolenie ogląda schyłek PRL-u, pełen politycznych paroksyzmów i nagłych zwrotów akcji. To pokolenie ogląda schyłek PRL-u, pełen politycznych paroksyzmów i nagłych zwrotów akcji.",2019),
            new Book(4,"Apetyt na życie ","Dowbor Katarzyna",28.83m,"Apetyt na życie.jpg","Opowieść, w której każde pokolenie kobiet znajdzie coś dla siebie. Katarzyna Dowbor, ikona polskiej telewizji, otwiera przed czytelniczkami drzwi do swojej prywatnej posiadłości. ",2019),
            new Book(5,"Blady król","Wallace David Foster",34.25m,"Blady król.jpg","Tematem powieści, której David Foster Wallace poświęcił ostatnich dziesięć lat życia, jest śmiertelna nuda. Dziesięć lat po samobójczej śmierci kultowego amerykańskiego pisarza jego dzieło w końcu trafia do rąk polskich czytelników.",2019),
            new Book(6,"Nietoperz i suszone cytryny","Meller Marcin",23.25m,"Nietoperz i suszone cytryny.jpg","Teksty pochodzące z lat 20162019 okraszone zostały barwnymi anegdotami o świecie mediów, opowieściami o miłości, polityce i straconych szansach, a także o ulubionych Mazurach i piłce nożnej.",2019),
            new Book(7,"Nie chcę być mały","Anderson Laura Ellen",15.82m,"Nie chcę być mały.jpg","Zabawna i inspirująca opowieść o sztuce kochania tego, kim jesteśmy. Bez względu na rozmiar. Zapewne słyszeliście kiedyś, jak Wasze dziecko woła: O nie! Nie chcę być ...! ",2019),
            new Book(8,"Las zły ","Grek",40.13m,"Las zły.jpg","Końcówka lat dziewięćdziesiątych na pograniczu polsko-niemieckim. Gangsterzy i przemytnicy czują się bezkarnie, policja działa nieudolnie, a społeczeństwo na dorobku interesuje się przede wszystkim zarabianiem pieniędzy, by jakoś wiązać koniec z końcem.",2019),
        };        
    }
}