(ns fizz-buzz-clj.core-test
  (:require [clojure.test :refer :all]
            [fizz-buzz-clj.core :refer :all]))

(deftest plain-numbers
  (testing "Is converted to one"
    (is (= (convert 1) 1)))
  (testing "Two is converted to two"
    (is (= (convert 2) 2))))

(deftest fizz
  (testing "Three is converted to fizz"
    (is (= (convert 3) :fizz)))
  (testing "Six is converted to fizz"
    (is (= (convert 6) :fizz))))

(deftest buzz
  (testing "Five is converted to buzz"
    (is (= (convert 5) :buzz)))
  (testing "Ten is converted to buzz"
    (is (= (convert 10) :buzz))))

(deftest fizzbuzz
  (testing "Fifteen is converted to fizzbuzz"
    (is (= (convert 15) :fizzbuzz)))
  (testing "Thirty is converted to fizzbuzz"
    (is (= (convert 30) :fizzbuzz))))

(deftest head-of-fizz-buzz
  (testing "First five numbers of fizz buzz"
    (is (= (take 5 (fizz-buzz)) '(1 2 :fizz 4 :buzz)))))

(deftest fizz-buzz-from-11-to-15
  (testing "Numbers from 11 to 15 converted to fizzbuzz"
    (is (= (take 5 (drop 10 (fizz-buzz))) '(11 :fizz 13 14 :fizzbuzz)))))
