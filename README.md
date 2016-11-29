# Sharp Dynamic Extentions

Method extention library for .net

#How to use

#stings

- "github.com".testRegex("^[a-zA-Z0-9][a-zA-Z0-9-]{1,61}[a-zA-Z0-9](\.[a-zA-Z]{2,}){1,}$") - //returns true
- "github.com".isDomain() // returns true
- "ravillion@mail.ru".isEmail() - returns false, if is invalid email format
- "abracodabra".toMd5() - returns md5 string

#Assembly Exploring

AssemblyExplorer.Successors<TInterface> returns all classes implemented from TInterface

AssemblyExplorer.NameEnds   returns all classes name ends with.
AssemblyExplorer.NameEnds<TInterface> return all classes imlemented from TInterface

AssemblyExplorer.NameStarts returns all classes name starts with.
AssemblyExplorer.NameEnds<TInterface> return all classes imlemented from TInterface with name starts
