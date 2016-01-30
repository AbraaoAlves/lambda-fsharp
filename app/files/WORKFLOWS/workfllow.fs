
//CAMINHO FELIZ

let createUser =
    validateRequest
    >> verifyEmail
    >> db.createUser
    >> smtpServer.sendEmail
    >> returnMessage
    
