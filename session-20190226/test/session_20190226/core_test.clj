(ns session-20190226.core-test
  (:require [clojure.test :refer :all]
            [session-20190226.core :refer :all]))

(deftest a-test
  (testing "Two sum return correct position."
    (are [expected actual] (= expected actual)
      [0 1] (two-sum [2 7 11 15] 9)
      [1 2] (two-sum [15 2 7 11] 9)
      [1 2] (two-sum [15 7 2 11] 9)
      [1 3] (two-sum [15 7 11 2] 9)
      [0 2] (two-sum [2 11 7 15] 9)
      [0 1] (two-sum [2 11 7 15] 13)
      [0 1] (two-sum [3 10 7 15] 13)
      [0 3] (two-sum [0 10 7 15] 15)
      [1 2] (two-sum [0 10 7 15] 17))))

(deftest test-vec-to-map
  (testing "Converted array to map is correct."
    (is (= {1 0, 2 1} (vec-to-map [1 2])))))