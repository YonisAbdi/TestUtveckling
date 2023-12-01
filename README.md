Rapport:
Min uppgift var att skapa en enkel applikation för hantering av användarkonton som låter användare läggas till, raderas och laddas ner från simulatordatabasen. 
För att lösa uppgiften implementerade jag ett användargränssnitt (IDatabase), en användarstruktur (User) och en klass för att hantera användare (UserManager). Därefter skrev jag tester för användarhanterare med  Moq för att simulera databasinteraktioner. 
En av utmaningarna jag stod inför var att göra koden så generisk som möjligt samtidigt som den uppfyllde de givna kraven. En annan utmaning var att implementera tester som täckte alla delar av UserManager-klassen.

Lösningar:
Jag bestämde mig för att använda ett gränssnitt (IDabase) som gör det enkelt att håna databasinteraktioner. Detta gjorde att koden blev mer flexibel och utbytbar.
Jag använde mig av Moq för att skapa mockobjekt av databasgränssnittet, vilket gjorde det möjligt att isolera enhetstesterna och verifera UserManager och IDatabase.
Det fanns lite svårigheter med konstruktorinjektion i UserManager, men fick till med att tillhandahålla IDatabase.


Test Inlämning SkärmDump
![Testing2](https://github.com/YonisAbdi/TestInl-mning/assets/133973900/d89bba22-e2af-4b80-bb05-ee9248eb32d0)
