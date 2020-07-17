# BookManager
- ### C#을 활용한 도서 관리
- ### 개발 환경 : VisualStudio 2019, DBMS : Microsoft SQL Server2012
- ### 기능 
  #### HomeButton : 도서 수, 사용자 수, 대출중인 도서의 수, 연체중인 도서의 수 확인
  #### 도서 추가, 수정, 삭제
  #### 사용자 등록, 수정, 삭제
  #### 도서 대여 및 

## 초기화면
 ### Home
 - 초기 화면에서는 전체 도서 수, 사용자 수, 대출중인 도서의 수, 연체중인 도서의 수를 확인할 수 있다.
 
 ![image](https://user-images.githubusercontent.com/62640232/87032416-8cc95180-c21f-11ea-8e10-caa3b0988fd6.png)
 
 </br>
 
## BookManager
 ### 도서 현황
 - 도서 현황에서 책을 선택하면 도서 추가/수정/삭제 textBox가 변경하는 것을 확인할 수 있다.

![image](https://user-images.githubusercontent.com/62640232/87032543-bf734a00-c21f-11ea-8e12-1515ebc7c981.png)

</br>

 ### 도서 추가
- Isbn, 도서 이름, 출판사, 페이지를 textBox에 입력하고 추가버튼을 누르면 도서 현황에서 추가되었음을 확인할 수 있다.
- 이미 있는 Isbn 값을 입력 했을 경우에는 “이미 존재하는 도서입니다.”라고 알림이 뜬다.

![image](https://user-images.githubusercontent.com/62640232/87032675-edf12500-c21f-11ea-94e6-067fdd75fe2b.png)
![image](https://user-images.githubusercontent.com/62640232/87032699-f9445080-c21f-11ea-8783-00f346982c78.png)

</br>

### 도서 수정
- 원하는 도서를 선택한 다음 수정할 내용을 textBox에서 수정하고 수정버튼을 누르면 도서 현황에서 
  수정된 도서 이름과 페이지를 확인할 수 있다.
- 이미 없는 Isbn 값을 입력 했을 경우에는 “존재하지 않는 도서입니다.”라고 알림이 뜬다.

![image](https://user-images.githubusercontent.com/62640232/87032886-40324600-c220-11ea-8a76-f665282b7618.png)
![image](https://user-images.githubusercontent.com/62640232/87032918-4c1e0800-c220-11ea-8167-453b39c5be7c.png)

</br>

### 도서 삭제
- 원하는 도서를 도서 현황에서 선택한 다음 삭제버튼을 누르면 도서 현황에서 삭제된 것을 확인할 수 있다.
- 이미 없는 Isbn 값을 입력 했을 경우에는 “존재하지 않는 도서입니다.”라고 알림이 뜬다.

![image](https://user-images.githubusercontent.com/62640232/87033005-6c4dc700-c220-11ea-9f3f-c09b398da2fd.png)
![image](https://user-images.githubusercontent.com/62640232/87033028-753e9880-c220-11ea-9b5f-e984fb5ca297.png)

</br>

### 사용자 확인
- 사용자 현황에서 사용자를 선택하면 그 사용자의 ID와 이름으로 textBox의 값이 변경되는 것을 확인할 수 있다.

![image](https://user-images.githubusercontent.com/62640232/87033567-66a4b100-c221-11ea-8bde-97169cfa51ef.png)

</br>

### 사용자 추가
- 사용자 ID와 이름을 textBox에 입력하고 추가버튼을 누르면 사용자 현황에서 추가된 것을 확인할 수 있다.
- 이미 있는 사용자 ID를 입력하면 “이미 등록된 사용자입니다”라고 알림이 뜬다. 

![image](https://user-images.githubusercontent.com/62640232/87033519-542a7780-c221-11ea-8a53-90de2f069061.png)
![image](https://user-images.githubusercontent.com/62640232/87033527-57256800-c221-11ea-8fef-707adee8a691.png)

</br>

### 사용자 수정
- 사용자 현황에서 사용자를 선택하고 수정할 내용을 textBox에서 수정하고 수정버튼을 누르면 사용자 현황에서 
  수정된 것을 확인할 수 있다.
- 없는 사용자 ID를 입력하면 “등록되지 않은 사용자입니다”라고 알림이 뜬다.

![image](https://user-images.githubusercontent.com/62640232/87033485-47a61f00-c221-11ea-9d33-d5b3b5fd2de6.png)
![image](https://user-images.githubusercontent.com/62640232/87033492-4aa10f80-c221-11ea-80a2-ff523903c545.png)

</br>

### 사용자 삭제
- 사용자 현황에서 사용자를 선택하고 삭제버튼을 누르면 사용자 현황에서 삭제된 것을 확인할 수 있다.
- 없는 사용자 ID를 입력하면 “등록되지 않은 사용자입니다”라고 알림이 뜬다.

![image](https://user-images.githubusercontent.com/62640232/87033449-365d1280-c221-11ea-840b-0103b1d8ed4e.png)
![image](https://user-images.githubusercontent.com/62640232/87033451-3826d600-c221-11ea-9154-654e6449eb8c.png)

</br>

### 도서 대여
- 사용자 현황에서 사용자를 선택하고 대여할 도서를 선택하고 대여버튼을 누르면 해당도서가 대여된
  것을 알려주는 알림이 뜬다. 
- 없는 Isbn 값, 사용자 ID 입력하면 “존재하지 않는 도서 또는 사용자입니다” 라는 알림이 뜬다.
- 이미 대여중인 도서를 대여하려고 하면 “이미 대여 중인 도서입니다”라는 알림이 뜬다.

![image](https://user-images.githubusercontent.com/62640232/87033404-22191580-c221-11ea-8036-c8e1689ad462.png)
![image](https://user-images.githubusercontent.com/62640232/87033413-25140600-c221-11ea-85e8-24bd1e6da855.png)
![image](https://user-images.githubusercontent.com/62640232/87033416-26ddc980-c221-11ea-81b9-8567f6071b44.png)
![image](https://user-images.githubusercontent.com/62640232/87033422-280ef680-c221-11ea-8a2a-1f771b19d6be.png)

</br>

### 도서 반납
-반납할 도서를 선택하고 반납버튼을 누르면 해당도서가 반납되었다고 알려주고 연체되었을 시 
 연체 되었다고 알려준다.  
- 없는 Isbn 값, 사용자 ID 입력하면 “존재하지 않는 도서 또는 사용자입니다” 라는 알림이 뜬다.
- 대여 상태가 아닌 도서를 반납하려고 하면 “대여 상태가 아닙니다”라는 알림이 뜬다.

![image](https://user-images.githubusercontent.com/62640232/87033323-fdbd3900-c220-11ea-8d80-d7f2919efdf4.png)
![image](https://user-images.githubusercontent.com/62640232/87033352-0c0b5500-c221-11ea-8762-22cb340d6d78.png)
![image](https://user-images.githubusercontent.com/62640232/87033369-1299cc80-c221-11ea-8002-ecaf10410f28.png)
![image](https://user-images.githubusercontent.com/62640232/87033375-16c5ea00-c221-11ea-8b17-ba5245718ef3.png)

</br>

















