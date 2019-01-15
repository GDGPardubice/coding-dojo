(ns session-20181211.core-test
  (:require [clojure.test :refer :all]
            [session-20181211.core :refer :all]))

(deftest no-mines
  (testing "Mines count at (0, 0) of board without mines is 0."
    (is (= 0 (mines-count #{} 0 0))))
  (testing "Mines count at (1, 0) of board without mines is 0."
    (is (= 0 (mines-count #{} 1 0)))))

(deftest one-mine
  (testing "Mines count at (0, 0) of board with mine on position (0, 1) is 1."
    (is (= 1 (mines-count #{[0 1]} 0 0))))
  (testing "Mines count at (0, 0) of board with mine on position (0, 2) is 0."
    (is (= 0 (mines-count #{[0 2]} 0 0))))
  (testing "Mines count at (0, 0) of board with mine on position (1, 0) is 0."
    (is (= 1 (mines-count #{[1 0]} 0 0))))
  (testing "Mines count at (2, 2) of board with mine on position (1, 0) is 0."
    (is (= 0 (mines-count #{[1 0]} 2 2))))
  (testing "Mines count at (0, 0) of board with mine on position (0, 0) is 0."
    (is (= 0 (mines-count #{[0 0]} 0 0))))
)

(deftest two-mines
  (testing "Mines count at (1, 1) of board with mine on position (0, 0)(1,0) is 0."
    (is (= 2 (mines-count #{[0 0][1 0]} 1 1))))
)

(+ 1 2)