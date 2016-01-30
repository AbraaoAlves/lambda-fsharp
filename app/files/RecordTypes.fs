//open Nunit.Framework
//open Swensen.unquote

type Account = {
    Name : string
    Licenses : Set<string>
}

let ``record type test`` () =
   let account1 = {Name = "Altum"; Licenses = set ["MIT"]}
   let account2 = {Name = "Altum"; Licenses = set ["MIT"]}
   test <@ account1 = account2@>
   //true
