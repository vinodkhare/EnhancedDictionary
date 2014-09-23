EnhancedDictionary
==================

An observable, order-preserving dictionary for C# .NET.

Has the following properties
* Is observable. Implements INotifyCollectionChanged (actually uses ObservableCollection as backend) and is suitable for data binding in WPF.
* The Keys and Values collections are observable as well. Both are implemented as ObservableCollections.
* Order is preserved. Key-Value pairs are enumerated in the order that they are added. This also allows the user to do things like Insert() which regular dictionaries cannot do.
* Implements IDictionary and can be used as a drop-in replacement for regular Dictionary.
* Multi-Dimentional implementation are provided. Ideal for storing multi-dimensional data.

See Program.cs for example usage.