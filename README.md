# BÀI TẬP C-SHARP OOP

## Lưu ý:
- Tất cả các bài trong này đều được tạo trên Console App của **C#, Visual Studio**.
- Mỗi bài sẽ tạo 1 Project riêng biệt, đặt tên: **Bai_1, Bai_2, ...**
- Tất cả các project cho đặt chung trong một **Solution OOP**

## Bài tập

### Bài 1:
1. Tạo custom **class Person** bao gồm:
  - **Property**:
    - **Id**
    - **Name**
    - **Age**
    - **Income**
    - **TaxCoe** (Hệ số thuế)
  - **Method**:
    - **Equals(Person p)**:<br>
    &nbsp;&nbsp;&nbsp;&nbsp;Xác định xem thông tin truyền vào<br>
    &nbsp;&nbsp;&nbsp;&nbsp;và thông tin hiện thời có phải cùng 1 người.
    - **GetTax()**:<br>
    &nbsp;&nbsp;&nbsp;&nbsp;Thông qua **TaxCoe** và **Income** tính toán<br>
    &nbsp;&nbsp;&nbsp;&nbsp;tiền thuế người đó phải nhập.

2. Trong **class Program**:<br>
Tạo **Method**:
    - **Init()**:<br>
    &nbsp;&nbsp;&nbsp;&nbsp;Khởi tạo một List<Person><br>
    &nbsp;&nbsp;&nbsp;&nbsp;có thể *hardcode* đầu vào.
    - **Output()**:<br>
    &nbsp;&nbsp;&nbsp;&nbsp;In ra màn hình thông tin của mỗi một người<br>
    &nbsp;&nbsp;&nbsp;&nbsp;trên cùng một dòng, bao gồm:
      - Id
      - Name
      - Tax

### Bài 2:
1. Tạo **class TaxData** bao gồm:<br>
Một method **GetTaxCoe()** để tính hệ số thuế theo logic sau:
  - Nếu "tuổi < 18" thì **hệ số thuế = 0**.
  - Nếu "tuổi > 18":
    - Nếu "**Income** <= 9_000_000" thì **hệ số thuế = 5%**.
    - Nếu "9_000_000 < **Income** <= 15_000_000" thì **hệ số thuế = 10%**.
    - Nếu "15_000_000 < **Income** <= 20_000_000" thì **hệ số thuế = 15%**.
    - Nếu "20_000_000 < **Income** <= 30_000_000" thì **hệ số thuế = 20%**.

2. Tạo **class Program** như **Bài 1** và chỉnh sửa như sau:<br>
  - Trong Constructor của **Person**, truyền vào một Instance của **TaxData**.
  - Sử dụng Instance này để tính toán hệ số thuế:

3. Xuất dữ liệu ra màn hình như bài 1.

### Bài 3:
1. Tạo **class TaxData** như bài 2.

2. Biến **class Person** thành Interface **IPerson**,<br>
thêm method **GetInfo()** để lấy ra thông tin cần thiết của 1 person.

2. Tạo thêm các **_class_** sau để tận dụng Interface **IPerson**,<br>
với các **_property_** sau:
  - **class Student**:
    - **property**:
      - Class (chỉ lớp học)
      - School
  - **class Teacher**:
    - **property**:
      - School
  - **class Employee**:
    - **property**:
      - Company
      - JobTitle

3. Khởi tạo dữ liệu với **TaxData** cho một List<Person> đủ các loại<br>
đối tượng (**Student**, **Teacher**, **Employee**)

4. Trong **class Program**, tạo **method Output()** để xuất ra màn hình thông tin sau:

&nbsp;&nbsp;&nbsp;&nbsp;**Student**: _Số_Lượng_
&nbsp;&nbsp;&nbsp;&nbsp;_ID_Name_Age_School_Class

&nbsp;&nbsp;&nbsp;&nbsp;**Teacher**: _Số_Lượng_
&nbsp;&nbsp;&nbsp;&nbsp;_ID_Name_Age_School_Income_Tax

&nbsp;&nbsp;&nbsp;&nbsp;**Employee**: _Số_Lượng_
&nbsp;&nbsp;&nbsp;&nbsp;_ID_Name_Age_Company_JobTitle_Income_Tax
