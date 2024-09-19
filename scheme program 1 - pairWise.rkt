#lang racket

;Jon Scales
;Scheme program 1
;Fall 2024
;CMPS 5113

;written using DrRacket IDE in racket scheme ver 8.14

;create lists to use
(define listA '(1 2 3 4 5 6))
(define listB '(A B C D E F))

(define listC '(red blue green yellow))
(define listD '(apple sky grass flower))

;function definition
(define (pairWise a b)
  (if(or(empty? a)(empty? b));base case test when either original list is empty
     '(); return an empty list if originals is empty
     (cons (list (car a)(car b)) (pairWise (cdr a) (cdr b)))))
          ;(list (car a)(car b) gets 1st atom in each original list and make new sublist
          ;cons combines (list result with result of recursive call on the original list remainders
          ;(pairWise (cdr a)(cdr b) recursively works on remaining items in original lists
          ;recursion continues until either original list is empty


;function call

(pairWise listA listB)
(newline)
(pairWise listC listD)
