/Models File/
   User.cs _ user's functional
   
   Accountant.cs_ accountants's functional
   
   Loan.cs _ bank loan's functional
   
/BankServices File/

    AccountantService.cs_ 
    1.add valid accountant 
    2.accountant job, check if user has loan da block it
  
    LoanService.cs _  
    1. get loan if user exists, 
    2.get infomation about loan 
    3.add loan

    UserService_
    1.registration, get properties from body
    2.change loan information if user is not blocked


/Controllers/

    AccountantController _ use accountant services functions
      1. add accountant info
      2.check user's info

    UserController _
      1.registration
      2.change loan

    LoanController _
      1.enter loan properties from body
      2.get infomation about user's loan
      3.get loan if user exists and is not blocked

    

    
