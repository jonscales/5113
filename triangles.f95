


program triangles

! Jon Scales
! Fall 2024 APL program 1
! triangle determination
! test if 2 values input by user can form a triangle
! further, determine internal angle values and triangle type
! (scalene, right, or equilateral) if values can form triangle

   !variable declarations
    implicit none 
  
    character(len = 15) :: name
    real :: sideA, sideB, sideC, rsideA, rsideB, rsideC, angleA, angleB, angleC, valA, valB, valC
    real :: PI=3.1415926535
    character(len = 1 ) :: more
    
    more = 'Y'
    ! Displayed program descriptor
    write (*, *)
    write (*, *) 'Jon Scales'
    write (*, *) 'Fortran Triangle Test Program'
    write (*, *) 'Fall 2024 '
    write (*, *)
    write (*, *) 'This program will determine if a set of 3 side of user specified lengths '
    write (*, *) 'can be arranged to generate a triangle. If a triangle can be formed, the '
    write (*, *) 'program will give the values of the internal angles opposite of each side.'
    write (*, *)
    write (*, *) 'Please enter your name: '
    write (*, *)
    read *, name
   
    !loop to read in side lengths until user replys N allows for multiple tests
    do while (more == 'Y' .OR. more =='y')
        write (*, *)
        write (*, *) 'Hi ', trim(name), ', Please enter values for the lengths of three possible sides '
        write (*, *) '(enter all 3 values separated by a space, then hit enter)'
        write (*, *)
        read *, sideA, sideB, sideC
        rsideA = real((INT((sideA * 10.0)+.5)) / 10.0)
        rsideB = real((INT((sideB * 10.0)+.5)) / 10.0)
        rsideC = real((INT((sideC * 10.0)+.5)) / 10.0)
        
        
        ! logic to determine if side lengths can form triangle
        if ((rsideA + rsideB) == rsideC .OR. (rsideB + rsideC) == rsideA .OR. (rsideA + rsideC) == rsideB) then
            write (*, *)
            write (*, *) 'These lengths will produce a degenerate triangle'
            write (*, *)
        else if ((rsideA > (rsideB + rsideC)) .OR. (rsideB > (rsideA + rsideC)) .OR. (rsideC > (rsideA + rsideB))) then
          write (*, *)
          write (*, *) "I'm sorry ", trim(name), ', these lengths can not be formed into a triangle'
          write (*, *)
        else
          write (*, *)
          write (*, *) 'Good news ', trim(name), '! These lengths CAN BE formed into a triangle'
          write (*, *)
          
          !calculate interior angles of triangle
          !write (*, '(f4.1)') rsideA**2, rsideB**2, rsideC**2
          valC = (rsideA**2 + rsideB**2 - rsideC**2) / (2 * rsideA * rsideB)
          !write (*, '(A, f4.1)') 'valC = ', valC
          angleC = ACOS(valC)*(180/PI)
          !write (*, '(A, f4.1)') 'angleC = ', angleC
          valB = (rsideA**2 + rsideC**2 - rsideB**2) / (2 * rsideA * rsideC)
          !write (*, '(A, f4.1)') 'valB = ', valB
          angleB = ACOS(valB)*(180/PI)
          !write (*, '(A, f4.1)') 'angleB = ', angleB
          angleA = 180 - angleC - angleB
         
          !determine type of triangle
          if (angleA == 90 .OR. angleB == 90 .OR. angleC == 90) then
            write (*, *) 'The triangle formed is a right triangle'
            write (*, *)
          else if (rsideA == rsideB .AND. rsideA == rsideC .AND. rsideB == rsideC) then
            write (*, *) 'The triangle formed is an equilateral triangle'
            write (*, *)
          else if (rsideA == rsideB .OR. rsideA == rsideC .OR. rsideB == rsideC) then
            write (*, *) 'The triangle formed is an isoceles triangle'
            write (*, *)
          else
            write (*, *) 'The triangle is a scalene triangle'
            write (*, *)
            end if
           
           !display internal angle values
           write (*, *) 'The internal angles (in degrees) of the triangle are: '
           write (*, *)
           write (*, '(f0.2, A, f0.1)') angleA, ' opposite the side of length ',rsideA
           write (*, '(f0.2, A, f0.1)') angleB, ' opposite the side of length ',rsideB
            write (*, '(f0.2, A, f0.1)') angleC, ' opposite the side of length ',rsideC
            write (*, *)
        end if
        write (*, *) 'Would you like to test another set of values? (Y or N)'
        write (*, *)
        read *, more
    end do    
    write (*, *)
    write (*, *) 'Thanks for using my triangles program! Goodbye'
    
    
  end program triangles
  
  
  
  
  
  
