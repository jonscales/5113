#lang racket

;Jon Scales
;Scheme program 1
;Fall 2024
;CMPS 5113

;written using DrRacket IDE in racket scheme

;create lists to use
(define listA '(1 2 3 4 5 6))
(define listB '(A B C D E F))

(define listC '(red blue green yellow))
(define listD '(apple sky grass flower))

;function definition
(define (pairWise a b)
  (if(or(empty? a)(empty? b));base case test when either original list is empty
     '(); return an empty list if originals is empty
     (cons (list (car a)(car b))(pairWise (cdr a) (cdr b)))))
          ;car a & car b: get 1st atom in each list
          ;list ( ) make a new list with car a and car b result
          ;cons combines this new list with the recursive call on the list remainders
          ;pairWise with cdr a & cdr b as parameters is recursive call
;function will work even if lists are of unequal length matching only those items until one list becomes empty

;function call

(pairWise listA listB)
(newline)
(pairWise listC listD)