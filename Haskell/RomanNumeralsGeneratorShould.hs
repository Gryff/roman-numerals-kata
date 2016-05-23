module RomanNumeralsGeneratorShould where 
    
import RomanNumeralsGenerator

import Test.Hspec
import Test.QuickCheck
import Text.Printf (printf)


testConvert :: String -> Int -> Spec
testConvert numerals decimal = 
    it (printf "should convert I to 1: %s - %d" numerals decimal) $
        convert numerals `shouldBe` decimal

main = hspec $ do 
    
    describe "RomanNumeralsGenerator" $ do 
        testConvert "I" 1