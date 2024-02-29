using LibraryService.Models;

Console.WriteLine("Starting Program...");
Console.WriteLine("Instancing classes");

var unit = new Unit();
var address  = new Address();
var person = new Person();
var rental  = new Rental();

var books  = new List<Book>();

var romance = new Category(1, "Romance", "The novel is a narrative literary form written in prose that became popular in " +
    "Western literature during the 19th century.");

var fiction = new Category(2, "Fiction", "Fiction books are those that tell an imagined story, without necessarily having anything to do with reality");

var machadoAssis = new Author(1, books, "Joaquim Maria Machado de Assis was a Brazilian writer, considered by many critics, scholars, writers and " +
    "readers the greatest name in Brazilian literature.");

var jorgeAmado = new Author(2, books, "Jorge Amado was one of the most famous and translated Brazilian writers of all time," +
    " being the author most adapted for film, theater and television.");

var domCasmurro = new Book(
    1,
    "Dom Casmurro",
    "Dom Casmurro tells the story of Bento Santiago (Bentinho), nicknamed Dom Casmurro for being quiet and introverted. " +
    "As a teenager, he falls in love with Capítu, abandoning the seminary and, with him, the plans laid down by his mother, Dona Glória, " +
    "so that he could become a priest.",
    machadoAssis,
    romance,
    true
    );

var brasCubas = new Book(
    2,
    "Memórias Póstumas de Brás Cubas",
    "After his death in 1869, Brás Cubas decides to narrate his story and revisit the most important events of his life in order to distract himself " +
    "in eternity. From then on, he remembers friends like Quincas Borba, his lackluster academic education in Portugal, the loves of his life and the " +
    "privilege he had of never having had to work in his life.",
    machadoAssis,
    romance,
    true
    );

var capitaesDaAreia = new Book(
    3,
    "Capitães da Areia",
    "Pedro Bala, Professor, Gato, Sem Pernas and Boa Vida are teenagers abandoned by their families, who grow up on the streets of Salvador and live in a " +
    "community in Trapiche. They commit a series of robberies and are constantly pursued by the police. One day, Professor meets Dora and her brother " +
    "Zé Fuinha and takes them to the Trapiche, which excites the other boys, who are not used to the presence of a woman there. Little by little, " +
    "affection develops between the leader of the group and the young girl.",
    jorgeAmado,
    fiction,
    true
    );

var marMorto = new Book(
    4,
    "Mar Morto",
    "The life of sailors on the docks of Salvador, with its rich mythology revolving around Iemanjá, is the central theme of Mar morto, " +
    "a lyrical and tragic panel about the daily struggle of these workers for survival.",
    jorgeAmado,
    fiction,
    true
    );

books.Add(domCasmurro);
books.Add(brasCubas);
books.Add(capitaesDaAreia);
books.Add(marMorto);

foreach (var book in books) 
{
    Console.WriteLine("id: " book.id);
    Console.WriteLine("name: " + book.name);
    Console.WriteLine("description: " + book.description);
    Console.WriteLine("author: " + book.author);
    Console.WriteLine("category: " + book.category);
    Console.WriteLine("available: " + book.available);
}
