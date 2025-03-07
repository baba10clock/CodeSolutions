class Solution {
    func dailyTemperatures(_ temperatures: [Int]) -> [Int] {
        var res: [Int] = Array(repeating: 0, count: temperatures.count)
        var stack = [Int]()

        stack.reserveCapacity(res.count)

        for i in 0..<temperatures.count {

            while !stack.isEmpty && temperatures[stack.last!] < temperatures[i] {
                let last = stack.removeLast()
                res[last] = i - last
            }

            stack.append(i)
        }

        return res
    }
}