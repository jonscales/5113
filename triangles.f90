


program triangles
   
    implicit none 
  
    character(len = 15) :: name

    real :: num1, num2, num3, roundNum1, roundNum2, roundNum3 
    character(len = 1 ) :: more

    more = 'Y'
    write (*, *)
    write (*, *) 'Jon Scales'
    write (*, *) 'Fortran Triangle Test Program'
    write (*, *) 'Fall 2024 '
    write (*, *)
    write (*, *) 'This program will determine if 3 lengths can be arranged to generate a triangle'
    write (*, *)
    write (*, *) 'Please enter your name: '
    read *, name
    do while (more == 'Y' .OR. more =='y')
        write (*, *) 'Please enter three length values (separate values with a space) '
        read *, num1, num2, num3
        roundNum1 = NINT(num1 * 10.0) / 10.0
        roundNum2 = NINT(num2 * 10.0) / 10.0
        roundNum3 = NINT(num3 * 10.0) / 10.0
        ! write (*, *) 'Hello ', name
        if (roundNum1 > (roundNum2 + roundNum3)) then
          write (*, *) "I'm sorry ", name, ' these lengths can not be formed into a triangle'
        else if (roundNum2 > (roundNum1 + roundNum3)) then
          write (*, *) "I'm sorry ", name, ' these lengths can not be formed into a triangle'
        else if (roundNum3 > (roundNum1 + roundNum2)) then
          write (*, *) 'These lengths CAN NOT be formed into a triangle'
        else
          write (*, *) 'Good news ', name, '! These lengths CAN BE formed into a triangle'
        end if
        write (*, *) 'Would you like to test another set of values? (Y or N)'
        read *, more
    end do    
    
    write (*, *) 'Thanks for using my triangles program! Goodbye'
    
    
  end program triangles
  
  
  
  
  
  
