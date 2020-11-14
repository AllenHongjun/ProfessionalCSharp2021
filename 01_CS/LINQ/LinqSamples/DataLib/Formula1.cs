﻿using System.Collections.Generic;

namespace DataLib
{
    public static class Formula1
    {
        private static List<Racer>? s_racers;

        private static List<Racer> InitializeRacers() =>
            new()
            {
                new ("Nino", "Farina", "Italy", 33, 5, new [] { 1950 }, new [] { "Alfa Romeo" }),
                new ("Alberto", "Ascari", "Italy", 32, 13, new [] { 1952, 1953 }, new [] { "Ferrari" }),
                new ("Juan Manuel", "Fangio", "Argentina", 51, 24, new int[] { 1951, 1954, 1955, 1956, 1957 }, new string[] { "Alfa Romeo", "Maserati", "Mercedes", "Ferrari" }),
                new ("Mike", "Hawthorn", "UK", 45, 3, new int[] { 1958 }, new string[] { "Ferrari" }),
                new ("Phil", "Hill", "USA", 48, 3, new int[] { 1961 }, new string[] { "Ferrari" }),
                new ("John", "Surtees", "UK", 111, 6, new int[] { 1964 }, new string[] { "Ferrari" }),
                new ("Jim", "Clark", "UK", 72, 25, new int[] { 1963, 1965 }, new string[] { "Lotus" }),
                new ("Jack", "Brabham", "Australia", 125, 14, new int[] { 1959, 1960, 1966 }, new string[] { "Cooper", "Brabham" }),
                new ("Denny", "Hulme", "New Zealand", 112, 8, new int[] { 1967 }, new string[] { "Brabham" }),
                new ("Graham", "Hill", "UK", 176, 14, new int[] { 1962, 1968 }, new string[] { "BRM", "Lotus" }),
                new ("Jochen", "Rindt", "Austria", 60, 6, new int[] { 1970 }, new string[] { "Lotus" }),
                new ("Jackie", "Stewart", "UK", 99, 27, new int[] { 1969, 1971, 1973 }, new string[] { "Matra", "Tyrrell" }),
                new ("Emerson", "Fittipaldi", "Brazil", 143, 14, new int[] { 1972, 1974 }, new string[] { "Lotus", "McLaren" }),
                new ("James", "Hunt", "UK", 91, 10, new int[] { 1976 }, new string[] { "McLaren" }),
                new ("Mario", "Andretti", "USA", 128, 12, new int[] { 1978 }, new string[] { "Lotus" }),
                new ("Jody", "Scheckter", "South Africa", 112, 10, new int[] { 1979 }, new string[] { "Ferrari" }),
                new ("Alan", "Jones", "Australia", 115, 12, new int[] { 1980 }, new string[] { "Williams" }),
                new ("Keke", "Rosberg", "Finland", 114, 5, new int[] { 1982 }, new string[] { "Williams" }),
                new ("Niki", "Lauda", "Austria", 173, 25, new int[] { 1975, 1977, 1984 }, new string[] { "Ferrari", "McLaren" }),
                new ("Nelson", "Piquet", "Brazil", 204, 23, new int[] { 1981, 1983, 1987 }, new string[] { "Brabham", "Williams" }),
                new ("Ayrton", "Senna", "Brazil", 161, 41, new int[] { 1988, 1990, 1991 }, new string[] { "McLaren" }),
                new ("Nigel", "Mansell", "UK", 187, 31, new int[] { 1992 }, new string[] { "Williams" }),
                new ("Alain", "Prost", "France", 197, 51, new int[] { 1985, 1986, 1989, 1993 }, new string[] { "McLaren", "Williams" }),
                new ("Damon", "Hill", "UK", 114, 22, new int[] { 1996 }, new string[] { "Williams" }),
                new ("Jacques", "Villeneuve", "Canada", 165, 11, new int[] { 1997 }, new string[] { "Williams" }),
                new ("Mika", "Hakkinen", "Finland", 160, 20, new int[] { 1998, 1999 }, new string[] { "McLaren" }),
                new ("Michael", "Schumacher", "Germany", 287, 91, new int[] { 1994, 1995, 2000, 2001, 2002, 2003, 2004 }, new string[] { "Benetton", "Ferrari" }),
                new ("Fernando", "Alonso", "Spain", 314, 32, new int[] { 2005, 2006 }, new string[] { "Renault" }),
                new ("Kimi", "Räikkönen", "Finland", 325, 21 , new int[] { 2007 }, new string[] { "Ferrari" }),
                new ("Lewis", "Hamilton", "UK", 262, 93, new int[] { 2008, 2014, 2015, 2017, 2018, 2019, 2020 }, new string[] { "McLaren", "Mercedes" }),
                new ("Jenson", "Button", "UK", 306, 16, new int[] { 2009 }, new string[] { "Brawn GP" }),
                new ("Sebastian", "Vettel", "Germany", 252, 53, new int[] { 2010, 2011, 2012, 2013 }, new string[] { "Red Bull Racing" }),
                new ("Nico", "Rosberg", "Germany", 207, 24, new int[] { 2016 }, new string[] { "Mercedes" })
            };

        public static IList<Racer> GetChampions() => s_racers ??= InitializeRacers();

        private static List<Team>? s_teams;
        public static IList<Team> GetConstructorChampions() =>   
            s_teams ??= new()
            {
                new ("Vanwall", 1958),
                new ("Cooper", 1959, 1960),
                new ("Ferrari", 1961, 1964, 1975, 1976, 1977, 1979, 1982, 1983, 1999, 2000, 2001, 2002, 2003, 2004, 2007, 2008),
                new ("BRM", 1962),
                new ("Lotus", 1963, 1965, 1968, 1970, 1972, 1973, 1978),
                new ("Brabham", 1966, 1967),
                new ("Matra", 1969),
                new ("Tyrrell", 1971),
                new ("McLaren", 1974, 1984, 1985, 1988, 1989, 1990, 1991, 1998),
                new ("Williams", 1980, 1981, 1986, 1987, 1992, 1993, 1994, 1996, 1997),
                new ("Benetton", 1995),
                new ("Renault", 2005, 2006 ),
                new ("Brawn GP", 2009),
                new ("Red Bull Racing", 2010, 2011, 2012, 2013),
                new ("Mercedes", 2014, 2015, 2016, 2017, 2018, 2019, 2020)
            };


        private static List<Championship>? s_championships;
        public static IEnumerable<Championship> GetChampionships() =>
            s_championships ??= new()
            {
                new (1950, "Nino Farina", "Juan Manuel Fangio", "Luigi Fagioli"),
                new (1951, "Juan Manuel Fangio", "Alberto Ascari", "Froilan Gonzalez"),
                new (1952, "Alberto Ascari", "Nino Farina", "Piero Taruffi"),
                new (1953, "Alberto Ascari", "Juan Manuel Fangio", "Nino Farina"),
                new (1954, "Juan Manuel Fangio", "Froilan Gonzalez", "Mike Hawthorn"),
                new (1955, "Juan Manuel Fangio", "Stirling Moss", "Eugenio Castellotti"),
                new (1956, "Juan Manuel Fangio", "Stirling Moss", "Peter Collins"),
                new (1957, "Juan Manuel Fangio", "Stirling Moss", "Luigi Musso" ),
                new (1958, "Mike Hawthorn", "Stirling Moss", "Tony Brooks"),
                new (1959, "Jack Brabham", "Tony Brooks", "Stirling Moss"),
                new (1960, "Jack Brabham", "Bruce McLaren", "Stirling Moss"),
                new (1961, "Phil Hill", "Wolfgang von Trips", "Stirling Moss"),
                new (1962, "Graham Hill", "Jim Clark", "Bruce McLaren"),
                new (1963, "Jim Clark", "Graham Hill", "Richie Ginther"),
                new (1964, "John Surtees", "Graham Hill", "Jim Clark"),
                new (1965, "Jim Clark", "Graham Hill", "Jackie Stewart"),
                new (1966, "Jack Brabham", "John Surtees", "Jochen Rindt"),
                new (1967, "Denny Hulme", "Jack Brabham", "Jim Clark"),
                new (1968, "Graham Hill", "Jackie Stewart", "Denny Hulme"),
                new (1969, "Jackie Stewart", "Jackie Ickx", "Bruce McLaren"),
                new (1970, "Jochen Rindt", "Jackie Ickx", "Clay Regazzoni"),
                new (1971, "Jackie Stewart", "Ronnie Peterson", "Francois Cevert"),
                new (1972, "Emerson Fittipaldi", "Jackie Stewart", "Denny Hulme"),
                new (1973, "Jackie Stewart", "Emerson Fittipaldi", "Ronnie Peterson"),
                new (1974, "Emerson Fittipaldi", "Clay Regazzoni", "Jody Scheckter"),
                new (1975, "Niki Lauda", "Emerson Fittipaldi", "Carlos Reutemann"),
                new (1976, "James Hunt", "Niki Lauda", "Jody Scheckter"),
                new (1977, "Niki Lauda", "Jody Scheckter", "Mario Andretti"),
                new (1978, "Mario Andretti", "Ronnie Peterson", "Carlos Reutemann"),
                new (1979, "Jody Scheckter", "Gilles Villeneuve", "Alan Jones"),
                new (1980, "Alan Jones", "Nelson Piquet", "Carlos Reutemann"),
                new (1981, "Nelson Piquet", "Carlos Reutemann", "Alan Jones"),
                new (1982, "Keke Rosberg", "Didier Pironi", "John Watson"),
                new (1983, "Nelson Piquet", "Alain Prost", "Rene Arnoux"),
                new (1984, "Niki Lauda", "Alain Prost", "Elio de Angelis"),
                new (1985, "Alain Prost", "Michele Alboreto", "Keke Rosberg"),
                new (1986, "Alain Prost", "Nigel Mansell", "Nelson Piquet"),
                new (1987, "Nelson Piquet", "Nigel Mansell", "Ayrton Senna"),
                new (1988, "Ayrton Senna", "Alain Prost", "Gerhard Berger"),
                new (1989, "Alain Prost", "Ayrton Senna", "Riccardo Patrese"),
                new (1990, "Ayrton Senna", "Alain Prost", "Nelson Piquet"),
                new (1991, "Ayrton Senna", "Nigel Mansell", "Riccardo Patrese"),
                new (1992, "Nigel Mansell", "Riccardo Patrese", "Michael Schumacher"),
                new (1993, "Alain Prost", "Ayrton Senna", "Damon Hill"),
                new (1994, "Michael Schumacher", "Damon Hill", "Gerhard Berger"),
                new (1995, "Michael Schumacher", "Damon Hill", "David Coulthard"),
                new (1996, "Damon Hill", "Jacques Villeneuve", "Michael Schumacher"),
                new (1997, "Jacques Villeneuve", "Heinz-Harald Frentzen", "David Coulthard"),
                new (1998, "Mika Hakkinen", "Michael Schumacher", "David Coulthard"),
                new (1999, "Mika Hakkinen", "Eddie Irvine", "Heinz-Harald Frentzen"),
                new (2000, "Michael Schumacher", "Mika Hakkinen", "David Coulthard"),
                new (2001, "Michael Schumacher", "David Coulthard", "Rubens Barrichello"),
                new (2002, "Michael Schumacher", "Rubens Barrichello", "Juan Pablo Montoya"),
                new (2003, "Michael Schumacher", "Kimi Räikkönen", "Juan Pablo Montoya"),
                new (2004, "Michael Schumacher", "Rubens Barrichello", "Jenson Button"),
                new (2005, "Fernando Alonso", "Kimi Räikkönen", "Michael Schumacher"),
                new (2006, "Fernando Alonso", "Michael Schumacher", "Felipe Massa"),
                new (2007, "Kimi Räikkönen", "Lewis Hamilton", "Fernando Alonso"),
                new (2008, "Lewis Hamilton", "Felipe Massa", "Kimi Räikkönen"),
                new (2009, "Jenson Button", "Sebastian Vettel", "Rubens Barrichello"),
                new (2010, "Sebastian Vettel", "Fernando Alonso", "Mark Webber"),
                new (2011, "Sebastian Vettel", "Jenson Button", "Mark Webber"),
                new (2012, "Sebastian Vettel", "Fernando Alonso", "Kimi Räikkönen"),
                new (2013, "Sebastian Vettel", "Fernando Alonso", "Mark Webber"),
                new (2014, "Lewis Hamilton", "Nico Rosberg", "Daniel Ricciardo"),
                new (2015, "Lewis Hamilton", "Nico Rosberg", "Sebastian Vettel"),
                new (2016, "Nico Rosberg", "Lewis Hamilton", "Daniel Ricciardo"),
                new (2017, "Lewis Hamilton", "Sebastian Vettel", "Valtteri Bottas"),
                new (2018, "Lewis Hamilton", "Sebastian Vettel", "Kimi Räikkönen"),
                new (2019, "Lewis Hamilton", "Valtteri Bottas", "Max Verstappen")
            };
        

        private static List<Racer>? _moreRacers;
        public static IList<Racer> GetMoreRacers() =>
            _moreRacers ??= new()
            {
                new Racer("Luigi", "Fagioli", "Italy", Starts: 7, Wins: 1),
                new Racer("Jose Froilan", "Gonzalez", "Argentina", 26, 2),
                new Racer("Piero", "Taruffi", "Italy", Starts: 18, Wins: 1),
                new Racer("Stirling", "Moss", "UK", Starts: 66, Wins: 16),
                new Racer("Eugenio", "Castellotti", "Italy", Starts: 14, Wins: 0),
                new Racer("Peter", "Collins", "UK", Starts: 32, Wins: 3),
                new Racer("Luigi", "Musso", "Italy", Starts: 24, Wins: 1),
                new Racer("Tony", "Brooks", "UK", Starts: 38, Wins: 6),
                new Racer("Bruce", "McLaren", "New Zealand", Starts: 100, Wins: 4),
                new Racer("Wolfgang von", "Trips", "Germany", Starts: 27, Wins: 2),
                new Racer("Richie", "Ginther", "USA", Starts: 52, Wins: 1),
                new Racer("Jackie", "Ickx", "Belgium", Starts: 116, Wins: 8),
                new Racer("Clay", "Regazzoni", "Switzerland", Starts: 132, Wins: 5),
                new Racer("Ronnie", "Peterson", "Sweden", Starts: 123, Wins: 10),
                new Racer("Francois", "Cevert", "France", Starts: 46, Wins: 1),
                new Racer("Carlos", "Reutemann", "Argentina", Starts: 146, Wins: 12),
                new Racer("Gilles", "Villeneuve", "Canada", Starts: 67, Wins: 6),
                new Racer("Didier", "Pironi", "France", Starts: 70, Wins: 3),
                new Racer("John", "Watson", "UK", Starts: 152, Wins: 5),
                new Racer("Rene", "Arnoux", "France", Starts: 149, Wins: 7),
                new Racer("Elio", "de Angelis", "Italy", Starts: 108, Wins: 2),
                new Racer("Michele", "Alboreto", "Italy", Starts: 194, Wins: 5),
                new Racer("Gerhard", "Berger", "Austria", Starts: 210, Wins: 10),
                new Racer("Riccardo", "Patrese", "Italy", Starts: 256, Wins: 6),
                new Racer("David", "Coulthard", "UK", Starts: 246, Wins: 13),
                new Racer("Heinz-Harald", "Frentzen", "Germany", Starts: 156, Wins: 3),
                new Racer("Eddie", "Irvine", "UK", Starts: 147, Wins: 4),
                new Racer("Rubens", "Barrichello", "Brazil", Starts: 322, Wins: 11),
                new Racer("Juan Pablo", "Montoya", "Columbia", Starts: 94, Wins: 7),
                new Racer("Felipe", "Massa", "Brazil", Starts: 269, Wins: 11),
                new Racer("Mark", "Webber", "Australia", Starts: 215, Wins: 9),
                new Racer("Daniel", "Ricciardo", "Australia", Starts: 183, Wins: 7),
                new Racer("Valtteri", "Bottas", "Finland", Starts: 151, Wins: 9),
                new Racer("Max", "Verstappen", "Netherlands", Starts: 114, Wins: 9)
            };        
    }
}