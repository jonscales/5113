


program triangles
   
    implicit none 
  
    character(len = 15) :: name

    real :: num1, num2, num3 

  
    write (*, *)
    write (*, *) 'Jon Scales'
    write (*, *) 'Fortran Triangle Test Program'
    write (*, *) 'Fall 2024 '
    write (*, *)
    write (*, *) 'This program will determine if 3 lengths can be arranged to generat a triangle'
    write (*, *)
    write (*, *) 'Please enter your name: '
    read *, name
    write (*, *) 'Please enter three length values (separate values with a space) '
    read *, num1, num2, num3
    write (*, *) 'Hello ', name
    if (num1 > (num2 + num3)) then
      write (*, *) 'These lengths can not be formed into a triangle'
    else if (num2 > (num1 + num3)) then
      write (*, *) 'These lengths can not be formed into a triangle'
    else if (num3 > (num1 + num2)) then
      write (*, *) 'These lengths can not be formed into a triangle'
    else
      write (*, *) 'These lengths could be formed into a triangle'
    end if 
  end program triangles