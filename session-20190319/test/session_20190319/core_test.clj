(ns session-20190319.core-test
  (:require [clojure.test :refer :all]
            [session-20190319.core :refer :all]))

(deftest merge-first-rest-test
  (testing "Merges one item with rest of list."
    (is (= '(1 2 2 3) (merge-first-rest '(1 2) '(2 3))))))

(deftest marge-two-lists-test
  (testing "Merges two sorted lists."
    (are [expected actual] (= expected actual)
      '() (merge-sorted-lists '() '())
      '(5) (merge-sorted-lists '() '(5))
      '(5) (merge-sorted-lists '(5) '())
      '(5 5) (merge-sorted-lists '(5) '(5))
      '(4 5) (merge-sorted-lists '(5) '(4))
      '(4 5) (merge-sorted-lists '(4) '(5))
      '(4 5 5) (merge-sorted-lists '(4 5) '(5))
      '(4 5 6) (merge-sorted-lists '(4 6) '(5))
      '(3 4 6) (merge-sorted-lists '(4 6) '(3))
      '(3 4 6 7) (merge-sorted-lists '(4 6) '(3 7))
      '(3 3 7 7) (merge-sorted-lists '(3 7) '(3 7)))))
    
(deftest merge-n-lists-test
  (testing "Merges n sorted lists."
    (are [expected actual] (= expected actual) 
      '() (merge-sorted-lists '() '() '())
      '(1 2 3) (merge-sorted-lists '(1) '(2) '(3))
      '(1 2 3 4) (merge-sorted-lists '(1) '(2) '(3) '(4)))))