Here is a list of commonly used **LINQ methods** in C# that work on collections like `List<T>`. These methods are part of the `System.Linq` namespace and apply to any class implementing `IEnumerable<T>`.

### **Filtering**
- **`Where`**: Filters elements based on a predicate.
  ```csharp
  var evenNumbers = numbers.Where(n => n % 2 == 0);
  ```

### **Projection**
- **`Select`**: Transforms each element in a sequence.
  ```csharp
  var squares = numbers.Select(n => n * n);
  ```

- **`SelectMany`**: Flattens nested collections into a single collection.
  ```csharp
  var allWords = sentences.SelectMany(s => s.Split(' '));
  ```

### **Sorting**
- **`OrderBy`**: Sorts elements in ascending order.
  ```csharp
  var sorted = numbers.OrderBy(n => n);
  ```

- **`OrderByDescending`**: Sorts elements in descending order.
  ```csharp
  var sorted = numbers.OrderByDescending(n => n);
  ```

- **`ThenBy`**: Performs a secondary ascending sort.
  ```csharp
  var sorted = people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName);
  ```

- **`ThenByDescending`**: Performs a secondary descending sort.
  ```csharp
  var sorted = people.OrderBy(p => p.LastName).ThenByDescending(p => p.Age);
  ```

### **Grouping**
- **`GroupBy`**: Groups elements by a specified key.
  ```csharp
  var grouped = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
  ```

### **Set Operations**
- **`Distinct`**: Removes duplicate elements.
  ```csharp
  var unique = numbers.Distinct();
  ```

- **`Union`**: Combines two sequences and removes duplicates.
  ```csharp
  var union = numbers.Union(moreNumbers);
  ```

- **`Intersect`**: Finds common elements between two sequences.
  ```csharp
  var intersection = numbers.Intersect(moreNumbers);
  ```

- **`Except`**: Removes elements in the second sequence from the first sequence.
  ```csharp
  var difference = numbers.Except(moreNumbers);
  ```

### **Joining**
- **`Join`**: Correlates elements from two sequences based on a key.
  ```csharp
  var joined = people.Join(orders,
      person => person.Id,
      order => order.PersonId,
      (person, order) => new { person.Name, order.OrderDate });
  ```

- **`GroupJoin`**: Groups elements from two sequences based on a key.
  ```csharp
  var groupedJoin = categories.GroupJoin(products,
      category => category.Id,
      product => product.CategoryId,
      (category, products) => new { category.Name, Products = products });
  ```

### **Element Operations**
- **`First`**: Returns the first element; throws an exception if none exist.
  ```csharp
  var first = numbers.First();
  ```

- **`FirstOrDefault`**: Returns the first element or default value if none exist.
  ```csharp
  var firstOrDefault = numbers.FirstOrDefault();
  ```

- **`Last` / `LastOrDefault`**: Similar to `First`, but for the last element.

- **`Single` / `SingleOrDefault`**: Ensures there is exactly one element, otherwise throws an exception (or returns default).

- **`ElementAt` / `ElementAtOrDefault`**: Gets the element at a specific index.

### **Quantifiers**
- **`Any`**: Checks if any elements satisfy a condition.
  ```csharp
  var hasEven = numbers.Any(n => n % 2 == 0);
  ```

- **`All`**: Checks if all elements satisfy a condition.
  ```csharp
  var areAllPositive = numbers.All(n => n > 0);
  ```

- **`Contains`**: Checks if a sequence contains a specific element.
  ```csharp
  var containsFive = numbers.Contains(5);
  ```

### **Aggregate Functions**
- **`Count`**: Counts the number of elements.
  ```csharp
  var count = numbers.Count();
  ```

- **`Sum`**: Computes the sum of elements.
  ```csharp
  var total = numbers.Sum();
  ```

- **`Average`**: Computes the average of elements.
  ```csharp
  var average = numbers.Average();
  ```

- **`Min`** / **`Max`**: Finds the minimum or maximum element.
  ```csharp
  var min = numbers.Min();
  var max = numbers.Max();
  ```

- **`Aggregate`**: Applies an accumulator function over the sequence.
  ```csharp
  var concatenated = words.Aggregate((current, next) => current + " " + next);
  ```

### **Partitioning**
- **`Take`**: Takes the first `n` elements.
  ```csharp
  var firstThree = numbers.Take(3);
  ```

- **`Skip`**: Skips the first `n` elements.
  ```csharp
  var skipped = numbers.Skip(3);
  ```

- **`TakeWhile`**: Takes elements while a condition is true.
  ```csharp
  var taken = numbers.TakeWhile(n => n < 10);
  ```

- **`SkipWhile`**: Skips elements while a condition is true.
  ```csharp
  var skipped = numbers.SkipWhile(n => n < 10);
  ```

### **Conversion**
- **`ToList`**: Converts a sequence to a `List<T>`.
  ```csharp
  var list = numbers.ToList();
  ```

- **`ToArray`**: Converts a sequence to an array.
  ```csharp
  var array = numbers.ToArray();
  ```

- **`ToDictionary`**: Converts a sequence to a dictionary.
  ```csharp
  var dictionary = people.ToDictionary(p => p.Id, p => p.Name);
  ```

- **`OfType`**: Filters elements of a specific type.
  ```csharp
  var strings = mixed.OfType<string>();
  ```

### **Others**
- **`DefaultIfEmpty`**: Returns a default value if the sequence is empty.
  ```csharp
  var withDefault = numbers.DefaultIfEmpty(0);
  ```

- **`Reverse`**: Reverses the order of elements.
  ```csharp
  var reversed = numbers.Reverse();
  ```

- **`Concat`**: Concatenates two sequences.
  ```csharp
  var concatenated = numbers.Concat(moreNumbers);
  ```

Let me know if you'd like examples or a deeper dive into any specific method!