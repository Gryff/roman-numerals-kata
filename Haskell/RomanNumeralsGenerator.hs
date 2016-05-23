module RomanNumeralsGenerator where

convert :: String -> Int 
convert numerals = foldl (\acc x -> acc + toDecimal x) 0 numerals

toDecimal :: Char -> Int 
toDecimal n = if n == 'V' then 5 else 1