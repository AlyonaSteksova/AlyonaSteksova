sumList :: [Integer] -> Integer
sumList []=0
sumList (x:xs)=x+sumList xs
