
<a name="readme-top"></a>

<!-- ABOUT THE PROJECT -->
## Om Prosjektet

Jeg har fått gleden av å videre utvikle tidligere studentprosjekt. Store deler av koden fungerer utmerket og er derfor ikke behov for endring, men enkelte ting som skal endres på er følgende:
- Oppdatere rammeverket
- Samkjøre med en SQL Database
- Sette opp Docker Container som tilhører Databasen
- Lage litt mer dokumentasjon for lettere oppsett

Grunnen for at jeg har lyst til å gjøre dette er fordi Egde trenger et slikt booking system og jeg har sterk tro om at det er mulig å få dette opp og gjøre med de riktige løsningene. Nå er jeg en Junior Konsulent, og har null erfaring med .NET og C#. Men jeg håper at jeg kan lære på det minste 1 ny ting i løpet av dette mini prosjektet mitt.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Laget med

Her er en liste over teknologier og verktøy brukt under utvikling:

* .NET 6
* Entity Framework
* C#
* Visual Studio Code
* Visual Studio (For migrering, så ikke nødvendig hvis du cloner dette)
* Docker
    * Docker Microsoft SQL Image
    * WSL 2 Backend
* Microsoft SQL Manager 

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Sette i gang

Det er et par ting du må ha klart på PC'en for at du skal kunne prøve kjøre dette systemet. Og jeg skal prøve å gå gjennom så enkelt og effektiv som mulig hvilke ting du må ha på plass og hvordan du får tak i de.

### Forhånds krav

Før du i det hele tatt kan klone Repo må du ha disse tingene på plass:

* .NET 6
Følg instruksjunene [her](https://dotnet.microsoft.com/en-us/download/dotnet)for nedlastning

* Docker
Følg instruksjunene [her](https://docs.docker.com/desktop/install/windows-install/). Husk også at WSL 2 er viktig. Dersom du ikke har det lastet ned og configurert vil ikke Docker fungere riktig. Etter at Docker er lastet ned burde det dukke opp et pop-up vindu som sier "WSL 2 Installation is incomplete". Følg linken for å installere Kernel oppdateringen og så skal Docker være klart til bruk.

* Visual Studio Code (
Personlig anbefaling, men du velger selv hvilken IDE/Text editor du bruker. Dersom VSC faller til smak, finner du link [her](https://code.visualstudio.com/download). 

* Microsoft SQL Manager (SSMS)
Dette blir verktøyet du bruker for å se på Databasen og hvordan ting ser ut. Følg instruksene [her](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16).

### Installation

Her går jeg kjapt gjennom fremgangsmåten for å få dette til å kjøre etter at du har lastet ned alle tingene under forhåndskrav.

1. Fullfør alt av installasjon under "Forhånds krav".
2. Clone repoet
   ```sh
   git clone https://github.com/EgdeConsulting/EgdeBookingSystemV2.git
   ```
3. Åpne opp Visual Studio Code og åpne prosjekt mappen i Workspace.
4. Åpne opp Docker Desktop
5. Åpne opp en terminal i Visual Studio Code i prosjektet ditt og installer den globale dotnet-ef pakken.
   ```sh
   dotnet tool install --global dotnet-ef
   ```
6. Sett opp og kjør docker containeren som skal være den lokale serveren for SQL.
Kjør først:
   ```sh
   docker pull mcr.microsoft.com/mssql/server:2022-latest
   ```
Deretter:
   ```sh
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Pass!word" -p 1433:1433 -d --name sqlserverdb -h localhost  mcr.microsoft.com/mssql/server:2022-latest
   ```
7. Start SSMS (SQL Manager)
8. Sørg for at Docker Container er oppe og kjører før du trykker "Connect". Velg disse paramterne
   ```sh
   Server type: Database Engine
   Server name: localhost, 1433
   Authentication: SQL Server Authentication
        Login: SA
        Password: Pass!word
   ```
9. Tilbake til VSC og oppdater databasen ved å skrive følgende i terminalen
   ```sh
   dotnet ef database update
   ```
10. Når builden er vellykket kan du trykke F5 på VSC som er shortcut for å kjøre .NET applikasjonen. Hvis ikke navigerer du deg til "Run and Debug" og kjører fra der.
11. Vent til det blir åpnet en lokal nettside hvor du kan registrere bruker og logge inn i systemet.


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Bruk

Forhåpentligvis kan dette prosjektet fullføres fullstendig og bruker av Egde til å booke utstyr og få en generell oversikt hvem som har hva.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Veien så langt

- [x] Porter fra .NET Core 3.1 til .NET 6
- [x] Sette opp Docker
- [x] Sette opp lokal SQL database
- [x] Koble sammen SQL Databasen med prosjekt
- [ ] Finne ut hvordan legge til nye tabeller
- [ ] Finne en annen løsning på hvordan migrere data
- [ ] Koble opp med Azure/Sharepoint

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->
## Kontakt info

Adel Hodzalari - adelh@egde.no

<p align="right">(<a href="#readme-top">back to top</a>)</p>



