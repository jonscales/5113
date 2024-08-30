


program triangles
   
    implicit none 
  
    character(len = 15) :: name
    real :: sideA, sideB, sideC, rsideA, rsideB, rsideC, angleA, angleB, angleC, valA, valB, valC 
    character(len = 1 ) :: more
    name = 'Jon'
    more = 'Y'
    write (*, *)
    write (*, *) 'Jon Scales'
    write (*, *) 'Fortran Triangle Test Program'
    write (*, *) 'Fall 2024 '
    write (*, *)
    write (*, *) 'This program will determine if 3 lengths can be arranged to generate a triangle'
    write (*, *)
    ! write (*, *) 'Please enter your name: '
    ! read *, name
    do while (more == 'Y' .OR. more =='y')
        write (*, *) 'Please enter three length values (separate values with a space) '
        read *, sideA, sideB, sideC
        rsideA = NINT(sideA * 10.0) / 10.0
        rsideB = NINT(sideB * 10.0) / 10.0
        rsideC = NINT(sideC * 10.0) / 10.0
        write (*, *) rsideA, rsideB, rsideC
        if ((rsideA + rsideB) == rsideC .OR. (rsideB + rsideC) == rsideA .OR. (rsideA + rsideC) == rsideB) then
            write (*, *) 'These lengths will generate a degenerate triangle'
        else if ((rsideA > (rsideB + rsideC)) .OR. (rsideB > (rsideA + rsideC)) .OR. (rsideC > (rsideA + rsideB))) then
          write (*, *) "I'm sorry ", trim(name), ', these lengths can not be formed into a triangle'
        else
          write (*, *) 'Good news ', trim(name), '! These lengths CAN BE formed into a triangle'
          !calculate interior angles of triangle
          write (*, *) rsideA**2, rsideB**2, rsideC**2
          valC = (rsideA**2 + rsideB**2 - rsideC**2) / (2 * rsideA * rsideB)
          write (*, *) 'valC = ', valC
          angleC = ACOS(valC)
          write (*, *) 'angleC = ', angleC
          valB = (rsideA**2 + rsideC**2 - rsideB**2) / (2 * rsideA * rsideC)
          write (*, *) 'valB = ', valB
          angleB = ACOS(valB)
          write (*, *) 'angleB = ', angleB
          angleA = 180 - angleC - angleB
          write (*, *) 'The internal angles of the triangle formed are: ',angleA, angleB, ' and, ', angleC
          
          if (angleA == 90 .OR. angleB == 90 .OR. angleC == 90) then
            write (*, *) 'This is a right triangle'
          else if (rsideA == rsideB .AND. rsideA == rsideB .AND. rsideB == rsideC) then
            write (*, *) 'The triangle is an equilateral triangle'
          else if (rsideA == rsideB .OR. rsideA == rsideC .OR. rsideB == rsideC) then
            write (*, *) 'The triangle is an isoceles triangle'
          else
            write (*, *) 'The triangle is a scalene triangle'
            end if
        end if
        write (*, *) 'Would you like to test another set of values? (Y or N)'
        read *, more
    end do    
    
    write (*, *) 'Thanks for using my triangles program! Goodbye'
    
    
  end program triangles
  
  
  
  
  
  
  
  
  
  
  
  
