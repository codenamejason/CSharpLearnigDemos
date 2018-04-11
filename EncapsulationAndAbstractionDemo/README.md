# Boxing VS Unboxing
Boxing is the process of converting a value type to the type object.

```
int i = 123;
object o = 1; // Boxing
```
Boxed values use more memory and take up at minumum two memory lookups to access.

---

Unboxing extracts the value type from the object.

Explicit.
````
object o = 456;
int i = (int)o; // Unboxing
````

---




