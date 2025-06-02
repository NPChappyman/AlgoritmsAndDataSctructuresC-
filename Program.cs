
using AlgoritmsAndDaraStructures.NET.Array;


Array<int> w = new Array<int>(10);
w.insert(1, 0);
w.insert(2, 0);
w.insert(1, 1);
w.insert(8, 2); w.insert(8, 2); w.insert(8, 2); w.insert(8, 2); w.insert(8, 2); w.insert(8, 2); w.insert(8, 2); w.insert(8, 2); w.insert(8, 2);
w.insert(9, 1); w.insert(7, 2);

w.display();
Console.WriteLine(w.find(8));
w.delete(1);
w.delete(7);
w.display();

Console.WriteLine();