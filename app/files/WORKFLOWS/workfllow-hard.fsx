//CAMINHO "TRISTE"

// type Result =
//     | Success
//     | Failure
// 
// type Result<'TEntity, 'TFailure> =
//     | Success of 'TEntity
//     | Failure of 'TFailure list
// 
// type Input = {
//     name : string
//     email : string
// }
// 
// type Result<Input> =
//     | Success of Input
//     | Failure of string
// 
// type ErrorMessage =
//     | NameMustNotBeBlank
//     | EmailNotValid of email
// 
// type Result<Input, ‘TFailure> =
//     | Success of Input
//     | Failure of ‘TFailure
// 
// let validateInput input =
//     if input.name = "" then
//         Failure NameMustNotBeBlank
//     elif Regex(emailP, input.email) then
//         Failure EmailNotValid
//     else 
//         Success input


type Result<'TSuccess,'TFailure> = 
    | Success of 'TSuccess
    | Failure of 'TFailure
    
type Request = {name:string; email:string}

let validateInput input =
   if input.name = "" then Failure "Name must not be blank"
   else if input.email = "" then Failure "Email must not be blank"
   else Success input  // happy path
   

