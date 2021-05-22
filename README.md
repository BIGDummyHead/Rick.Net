# Rick.Net

A simple wrapper for the [Rick and Morty API](https://rickandmortyapi.com/). 

This wrapper was built to be simple and allow you to get information on the fly about your favorite characters and such. 

All Snippets below are presumed to be in an Async Task. All Methods in Search.cs have their own CounterPart for Async and Synchronous

## Character

Snippet Resources:

[Beth's Mytholog](https://rickandmortyapi.com/api/character/40) - Json | ID : 40

```csharp

//there are many ways to gather a character.
Character x = await Search.GetCharacterAsync(40);
Multiple<Character> y = await Search.GetCharacterAsync(page:1, name:"Beth", status: Status.dead, gender: Gender.female);
//each page has 20 characters on them. 
Multiple<Character> characters = await Search.GetAllCharactersAsync(2);
Character z = characters.Results[19];

```

## Episode 

Snippet Resources:

[The ABC's of Beth](https://rickandmortyapi.com/api/episode/30) - Json | ID : 30

```csharp

//there are also many ways to gather an Episode.
Episode x = await Search.GetEpisodeAsync(30);
Multiple<Episode> y = await Search.GetEpisodeAsync(page:1, episodeName: null, episodeCode:"S03E09");
Multiple<Episode> episodes = await Search.GetAllEpisodesAsync(2);
Episode z = episodes.Results[9];

```

## Location 

Snippet Resources:

[Post-Apocalyptic Earth](https://rickandmortyapi.com/api/location/8) - Json | ID : 8

```csharp

//there are also many ways to gather an Location.
Location x = await Search.GetLocationAsync(8);
Multiple<Location> y = await Search.GetLocationAsync(page:1, name:"post-apocalyptic", type:null, dimension:null);
Multiple<Location> locations = await Search.GetAllLocationsAsync(1);
Location z = locations.Results[7];

```

## API Info

[Website](https://rickandmortyapi.com/)

[About](https://rickandmortyapi.com/about)

[Docs](https://rickandmortyapi.com/documentation)

[Api](https://rickandmortyapi.com/api/)

[Buy](https://rickandmortyapi.com/help-us) them a coffee

## Dependencies 

[NewtonSoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
