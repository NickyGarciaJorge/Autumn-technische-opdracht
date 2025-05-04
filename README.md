Blazor Multi-Step User Onboarding Flow
Dit project implementeert een multi-step user onboarding flow in Blazor voor een registratieproces, met een focus op gebruiksvriendelijkheid, toegankelijkheid en validatie. De applicatie bestaat uit vier stappen voor gebruikersregistratie en ondersteunt verschillende rollen voor de gebruiker.

**Hoe de applicatie te draaien**

Vereisten
Zorg ervoor dat je de volgende tools hebt geïnstalleerd:

.NET SDK (versie 6 of hoger)

Visual Studio 2022 of Visual Studio Code

Een webbrowser (zoals Chrome, Edge, of Firefox)

**Vanuit Visual Studio: **
1) Clone de repository:

	- Open Visual Studio.
	
	- Ga naar File > Clone Repository.
	
	- Voer de URL van de repository in:
		https://github.com/NickyGarciaJorge/Autumn-technische-opdracht.git
	
	- Klik op Clone.

2) Open het project:

	- Als het project eenmaal is gekloond, wordt het automatisch geopend in Visual Studio.
	
	- Als je het project handmatig wilt openen, ga dan naar File > Open > Project/Solution en selecteer de .sln-oplossing in de gekloonde repository.

3) Restore de afhankelijkheden:

	- Visual Studio zou automatisch de benodigde NuGet-pakketten moeten herstellen bij het openen van het project. Als dit niet gebeurt, kun je de pakketten handmatig herstellen door naar Tools > NuGet Package Manager > Restore NuGet Packages te gaan.

4) Start de applicatie:

	- Klik op de groene Run-knop (of druk op F5) om de applicatie in debug-modus uit te voeren.
	
	- Visual Studio opent een browser met de applicatie die draait op https://localhost:5001.


**Vanuit Visual Studio Code**
1) Clone de repository:

	- Open Visual Studio Code.
	
	- Ga naar Source Control-tab in Visual Studio Code.
	
	- Klik op Clone Repository en voer de URL van de repository in:
		https://github.com/NickyGarciaJorge/Autumn-technische-opdracht.git
	
	- Kies een map op je computer waar de repository gekloond moet worden.

2) Open de map in Visual Studio Code:

	- Klik op Open Folder en selecteer de map waar de repository is gekloond.

3) Restore de afhankelijkheden:

	- Open een terminal binnen Visual Studio Code (via View > Terminal).

	- Voer het volgende commando uit om de NuGet-pakketten te herstellen: dotnet restore

5) Start de applicatie:

	- In de terminal voer je het volgende commando uit om de applicatie te starten: dotnet run

	- De applicatie wordt nu uitgevoerd op https://localhost:5001. Visual Studio Code opent automatisch een browser.


**Core- en Stretch-functionaliteit**

**Core-functionaliteit**

Multi-step onboarding flow: De applicatie bestaat uit vier stappen voor het registreren van een nieuwe gebruiker:

 - Gebruikersnaam & e-mail

 - Wachtwoord & bevestiging

 - Rolkeuze (Admin, Manager, User)

 - Optioneel: Toestemming voor notificaties

 - Client-side validatie: Gebruik van DataAnnotations in combinatie met EditForm voor het valideren van invoervelden.

 - Mock API-endpoint: De applicatie maakt gebruik van een mock POST /api/register-endpoint, maar de echte implementatie kan worden geïntegreerd om gebruikers daadwerkelijk te registreren.

**Stretch-functionaliteit**

 - Toegankelijkheid (a11y): Toevoegen van ARIA-labels voor toegankelijkheid.

 - Visuele voortgangsindicator: Weergegeven door een progress bar die de gebruiker laat zien waar hij zich bevindt in het registratieproces.

