
//caminho feliz

string CreateUser(Request request) {
    validateRequest(request);
    verifyEmail(request);
    db.createUser(request);
    smtpServer.sendEmail(request.Email)
    return “OK”;
}
