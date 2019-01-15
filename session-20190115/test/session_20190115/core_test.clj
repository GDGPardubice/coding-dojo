(ns session-20190115.core-test
  (:require [clojure.test :refer :all]
            [session-20190115.core :refer :all]))

(deftest score-after-first-ball
  (testing "Returns score after first ball.")
  (are [expected actual] (= expected actual)
    [15 0] (next-score [0 0] :first)
    [0 15] (next-score [0 0] :second)))

(deftest score-after-second-ball
  (testing "Returns score after second ball.")
  (are [expected actual] (= expected actual)
    [30 0] (next-score [15 0] :first)
    [0 30] (next-score [0 15] :second)
    [15 15] (next-score [0 15] :first)
    [15 15] (next-score [15 0] :second)))

(deftest score-after-third-ball
  (testing "Returns score after third ball.")
  (are [expected actual] (= expected actual)
    [30 15] (next-score [15 15] :first)
    [15 30] (next-score [15 15] :second)
    [40 0] (next-score [30 0] :first)
    [0 40] (next-score [0 30] :second)
    [30 15] (next-score [30 0] :second)
    [15 30] (next-score [0 30] :first)))

(deftest score-after-fourth-ball
  (testing "Returns score after fourth ball.")
  (are [expected actual] (= expected actual)
    [40 15] (next-score [30 15] :first)
    [15 40] (next-score [15 30] :second)
    [30 30] (next-score [15 30] :first)
    [30 30] (next-score [30 15] :second)
    [40 15] (next-score [40 0] :second)
    [15 40] (next-score [0 40] :first)
    [0 :win] (next-score [0 40] :second)
    [:win 0] (next-score [40 0] :first)))

(deftest winner-ball
  (testing "Returns winner score after simple win game.")
  (are [expected actual] (= expected actual)
    [:win 15] (next-score [40 15] :first)
    [:win 30] (next-score [40 30] :first)
    [15 :win] (next-score [15 40] :second)
    [30 :win] (next-score [30 40] :second)))

(deftest deuce-ball
  (testing "Returns deuce score after both 40 points.")
  (are [expected actual] (= expected actual)
    [:advantage 40] (next-score [40 40] :first)
    [40 :advantage] (next-score [40 40] :second)))

(deftest win-after-advantage
  (testing "Returns winner score after advantage player scored.")
  (are [expected actual] (= expected actual)
    [40 :win] (next-score [40 :advantage] :second)
    [:win 40] (next-score [:advantage 40] :first)))

(deftest lost-advantage
  (testing "Returns players score after player lost advantage")
  (are [expected actual] (= expected actual)
    [40 40] (next-score [40 :advantage] :first)
    [40 40] (next-score [:advantage 40] :second)))