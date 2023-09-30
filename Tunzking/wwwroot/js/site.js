// Lấy các phần tử DOM cần thiết
const decrementButton = document.getElementById("decrement");
const incrementButton = document.getElementById("increment");
const valueInput = document.getElementById("value");

// Biến để lưu trữ giá trị hiện tại
let currentValue = 1;

// Định nghĩa hàm để giảm giá trị
decrementButton.addEventListener("click", function () {
    // Kiểm tra điều kiện trước khi giảm giá trị
    if (currentValue > 1) {
        currentValue--;
        valueInput.value = currentValue;
    }
});

// Định nghĩa hàm để tăng giá trị
incrementButton.addEventListener("click", function () {
    // Tăng giá trị lên 1
    currentValue++;
    valueInput.value = currentValue;
});
