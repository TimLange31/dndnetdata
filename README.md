# dndnetdata
D&amp;D 5e abstractions nuget package.

- Load the DI container using `services.AddStaticDndData()`
- Then inject the Interface into your constructor.
- for e.g. Spells use: `_{fieldName}.Spells`
- Enjoy :)
