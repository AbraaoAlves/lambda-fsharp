
//CAMINHO TRISTE

string Create(Request request) {
  var isValid = validateRequest(request);
  
  if (!isValid) { //AI
    return “Request is not valid”;
  }
  
  verifyEmail(request);
  
  try { //NO TRY! AIAI
    var result = db.createUser(request);
    
    if (!result) { //AIAIAI
      return “Conflict”;
    }
  } catch {
    return “DB error: User record not created”
  }
  
  if (!smtpServer.sendEmail(request.Email)) { //AIAIAIAIAI
    log.Error(“User email not sent.”);
  }
  return “OK”;
}
