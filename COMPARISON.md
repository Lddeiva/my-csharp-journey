

| Type | Add to End | Remove from End | Insert at Middle | Remove from Middle | Random Access | In-order access | Search for specific element | Add Beyond capacity | Resize |
|------|------------|-----------------|------------------|--------------------|---------------|-----------------|-----------------------------|---------------------|--------|
| <p align="center">`Array`</p> | <p align="center">O(n) ❤️</p> | <p align="center">O(n) ❤️</p> | <p align="center">O(n) ❤️</p> | <p align="center">O(n) ❤️</p> | <p align="center">O(1) 💚</p> | <p align="center">O(1) 💚</p> | <p align="center">O(n) ❤️</p> | <p align="center">❌</p> | <p align="center">❌</p> |
| <p align="center">`List<T>`</p> | <p align="center">O(1) 💚 </p>| <p align="center">O(1) 💚 </p>| <p align="center">O(n) ❤️</p> | <p align="center">O(n) ❤️</p> | <p align="center">O(1) 💚 | <p align="center">O(1) 💚 |  <p align="center">O(n) ❤️</p> |  <p align="center">O(n) ❤️</p> | It implements the IList<T> generic interface by using an array whose size is dynamically increased as required. |

Ref:-
- https://stackoverflow.com/questions/995766/comparison-of-collection-datatypes-in-c-sharp
- http://c-sharp-snippets.blogspot.com/2010/03/runtime-complexity-of-net-generic.html
- https://docs.microsoft.com/en-us/dotnet/standard/collections/selecting-a-collection-class?redirectedfrom=MSDN
- https://www.geeksforgeeks.org/time-complexities-of-all-sorting-algorithms/


| Type | Constructors | Properties | Methods | Sorting guaranty | Element access using | Null values | Type Safe | Performance considerations |
|------|--------------|------------|---------|------------------|----------------------|-------------|-----------|----------------------------|
|  <p align="center">`List<T>`</p> | <p align="center">`List<T>()` `List<T>(IEnumerable<T>)` `List<T>(Int32)`</p> | <p align="center">`Count` `Capacity` `Item[]`</p> |  <p align="center">`Add` `AddRange` `AsReadOnly` `BinarySearch` `Clear` `Contains` `ConvertAll` `CopyTo` `EnsureCapacity` `Exists` `Find` `FindAll` `FindIndex` `FindLast` `FindLastIndex` `ForEach` `GetEnumerator` `GetRange` `IndexOf` `Insert` `InsertRange` `LastIndexOf` `Remove` `RemoveAll` `RemoveAt` `RemoveRange` `Reverse` `Sort` `ToArray` `TrimExcess` `TrueForAll` </p> | <p align="center">not guaranteed ❤️</p>|  <p align="center">`0` based integer index</p> | accepts `null` as a valid value for reference types and allows duplicate elements. | Yes but consider boxing issues for Value Types | [`List<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0#performance-considerations) |
