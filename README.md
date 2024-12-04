# CountingSort
1-حدد أكبر عنصر في المصفوفة الأصلية.
2-أنشئ مصفوفة مساعدة (countArray) بنفس حجم القيمة القصوى +1 واملأها بالأصفار.
3-احسب تكرار كل عنصر في المصفوفة الأصلية وأضف هذه القيم إلى المصفوفة المساعدة.
4-احسب المجموع التراكمي في المصفوفة المساعدة.
5-أنشئ مصفوفة الإخراج (outputArray) بنفس حجم المصفوفة الأصلية.
6-ضع العناصر في مواقعها الصحيحة في outputArray باستخدام المصفوفة المساعدة.
7-انسخ القيم من outputArray إلى المصفوفة الأصلية.
Pseudo Code
1. Find the maximum value in the input array.
2. Create countArray of size (maxValue + 1) and initialize to 0.
3. Count each element in inputArray and store the count in countArray.
   For each element x in inputArray:
       countArray[x]++
4. Compute the cumulative sum in countArray.
   For i = 1 to countArray.Length - 1:
       countArray[i] += countArray[i - 1]
5. Create outputArray of the same size as inputArray.
6. Populate outputArray using countArray:
   For i = inputArray.Length - 1 down to 0:
       outputArray[countArray[inputArray[i]] - 1] = inputArray[i]
       countArray[inputArray[i]]--
7. Copy outputArray back to inputArray.
