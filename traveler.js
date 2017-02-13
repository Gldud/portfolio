var budgetController = (function(){
    var ExpenseCard = function(id, description, value){
        this.id = id;
        this.description = description;
        this.value = value;
    }
    
    var ExpenseCash = function(id, description, value){
        this.id = id;
        this.description = description;
        this.value = value;
    }
    
    var data = {
       allItems:{
            card:[],
            cash:[]
       },
       totals:{
           card:0,
           cash:0,
           totalExpense:0
       }
    };
    
   
    var calculateTotal = function(type){
         var sum = 0;
            data.allItems[type].forEach(function(cur){
                sum += cur.value;
            });
            data.totals[type] = sum;
    };
    
    return{
        addItem:function(type,des,val){
            var newItem, ID
            //create new ID
            if(data.allItems[type].length>0){
            ID = data.allItems[type][data.allItems[type].length-1].id+1;    
            }else{
                ID = 0;
            }
            
            //ID = last ID +1
            //Create new item 
            if(type === 'card'){
                newItem = new ExpenseCard(ID,des,val);
            }else if(type === 'cash'){
                newItem = new ExpenseCash(ID,des,val);
            }
            
            
            //Push it into data structure
            data.allItems[type].push(newItem);
            //Return the new element
            return newItem;
        },
        deleteItem:function(type,id){
            var ids,index;
            //위에 있는 id 현재 들어온 id
            ids = data.allItems[type].map(function(current){
                return current.id;//현재 id들을 배열로 만들어줌
            })
            
            index = ids.indexOf(id); //들어온 id의 위치
            if(index !== -1){
               data.allItems[type].splice(index,1); 
            }
        },
        
        calculateBudget:function(){
           calculateTotal('card');
           calculateTotal('cash');
           data.totals.totalExpense = data.totals.card+data.totals.cash
        },
        getExpense:function(){
          return{
              totalExpense:data.totals.totalExpense,
              totalCard:data.totals.card,
              totalCash:data.totals.cash
          }  
        },
        testing:function(){
            console.log(data)
        }
    };
})();
var UIController = (function(){
    var DOMstrings = {
      inputType:'.add__type',
      inputDescription:'.add__description',
      inputValue:'.add__value',
      inputBtn:'.add__btn',
      expenseContainer:'.expenses__list',
      totalLabel:'.budget__expenses--value',
      expensesCardLabel:'.card__expenses--value',
      expensesCashLabel:'.cash__expenses--value',
      container:'.container'
    };
    
    return{
        getInput:function(){
            return{
                type:document.querySelector(DOMstrings.inputType).value, //Will be either card or cash
                description:document.querySelector(DOMstrings.inputDescription).value,
                value:parseFloat(document.querySelector(DOMstrings.inputValue).value)    
            };
        },
        addListItems:function(obj,type){
            var html,newHtml,element;
          ///Create HTML String
          element = DOMstrings.expenseContainer;
          if(type === 'card'){
               html = '<div class="item clearfix" id="card-%id%"><i class="ion-card"></i><div class="item_description">%description%</div><div class="right clearfix"><div class="item__value">%value%</div><div class="item__delete"><button class="item__delete--btn"><i class="ion-ios-trash-outline"></i></button></div></div></div>'
          }else if(type ==='cash'){
               html = '<div class="item clearfix" id="cash-%id%"><i class="ion-cash"></i><div class="item_description">%description%</div><div class="right clearfix"><div class="item__value">%value%</div><div class="item__delete"><button class="item__delete--btn"><i class="ion-ios-trash-outline"></i></button></div></div></div>'    
          }
           newHtml = html.replace('%id%',obj.id);
           newHtml = newHtml.replace('%description%',obj.description);
           newHtml = newHtml.replace('%value%',obj.value);
           
          document.querySelector(element).insertAdjacentHTML('beforeend',newHtml);
        },
        
        deleteListItem:function(seletorID){
            var el =  document.getElementById(seletorID);
           el.parentNode.removeChild(el)
        },
        
        clearFields:function(){
            var fields,fieldsArr;
          fields = document.querySelectorAll(DOMstrings.inputDescription + ',' +DOMstrings.inputValue);
          //fields.slice() 안먹음
          fieldsArr = Array.prototype.slice.call(fields);
          fieldsArr.forEach(function(current,index,array){
              current.value = "";
          });
          document.activeElement.blur();
        },
        displayBudget:function(obj){
            document.querySelector(DOMstrings.totalLabel).textContent = obj.totalExpense;
            document.querySelector(DOMstrings.expensesCardLabel).textContent = obj.totalCard;
            document.querySelector(DOMstrings.expensesCashLabel).textContent = obj.totalCash;
           },
        getDOMstring:function(){
            return DOMstrings;
        }
    }
})();
var controller = (function(budgetCtrl, UICtrl){
    var setupEventListeners = function(){
        var DOM =UICtrl.getDOMstring();
        document.querySelector(DOM.inputBtn).addEventListener('click',ctrlAddItem);
        document.addEventListener('keypress',function(event){
            if(event.keyCode === 13){
                console.log('ENTER was pressed');
                ctrlAddItem();
            }
        });
        document.querySelector(DOM.container).addEventListener('click',ctrlDeleteItem);
    };
    
    var updateBudget = function(){
            budgetCtrl.calculateBudget();
            var expense = budgetCtrl.getExpense();
           UICtrl.displayBudget(expense);
    };
    var ctrlAddItem = function(){
         var input,newItem;
        // 1. Get the field input data
        input = UICtrl.getInput();
         if(input.description !=="" && !isNaN(input.value) && input.value>0){
              newItem = budgetCtrl.addItem(input.type,input.description,input.value);
              UICtrl.addListItems(newItem,input.type);
              UICtrl.clearFields();
              updateBudget();
         }
        
    };
    
    var ctrlDeleteItem = function(event){
        var itemID,splitID,type,ID;
        itemID = event.target.parentNode.parentNode.parentNode.parentNode.id;
        if(itemID){
            splitID = itemID.split('-');
            type = splitID[0];
            ID = parseInt(splitID[1]); 
            budgetCtrl.deleteItem(type,ID);
            UICtrl.deleteListItem(itemID);
             updateBudget();
        }
    };
        
    return{
        init:function(){
            console.log('Application has started.');
            setupEventListeners();
        }
    }
})(budgetController,UIController);
controller.init();