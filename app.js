var budgetController = (function(){
    var Expense = function(id, description, value){//function constructor
        this.id = id;
        this.description = description;
        this.value = value;
    }
    
    var data = {
        allExpenses:[],
        totals:[]
    };
    
    return{
        addItem:function(type,description,val){
            var newItem, ID;
            //create new ID
            if(data.allExpenses.length>0){
            ID = data.allExpenses[data.allExpenses.length-1].id+1;    
            }else{
                ID = 0;
            }
            
            //ID = last ID +1
            //Create new item 
            newItem = new Expense(ID, des, val);
            //Push it into data structure
            data.allExpenses.push(newItem);
            //Return the new element
            return newItem;
        },
        testing:function(){
            console.log(data)
        }
    };
})();

var UIController = (function(){
    var DOMstrings = {
      inputType:'.add_type',
      inputDescription:'.add__description',
      inputValue:'.add__value',
      inputBtn:'.add__btn',
      expenseContainer:'.expenses__list'
    };
    return {
      getInput:function(){
          return{
          type:document.querySelector(DOMstrings.inputType).value, //Will be either card or cash
          decription:document.querySelector(DOMstrings.inputDescription).value,
          value:document.querySelector(DOMstrings.inputValue).value    
          };
        },
        addListItems:function(obj,type){
            var html,newHtml,element;
            //Create HTML string with placeholder text
            element = DOMstrings.expenseContainer;
            if(type === 'cash'){
                
            }else if(type === 'card'){
                
            }
            //Replace the placeholder text with some actual data
            newHtml = html.replace('%id%',obj.id);
            newHtml = newHtml.replace('%description%',obj.description);
            newHtml = newHtml.replace('%value%',obj.value);
            //Insert the HTML into the DOM
            document.querySelector(element).insertAdjacentHTML('beforeend',newHtml);
        },
        clearFields:function(){
            var fields, fieldArr;
          fields = document.querySelectorAll(DOMstrings.inputDescription +','+
          DOMstrings.inputValue);
          var fieldArr = Array.prototype.slice.call(fields);
          fieldArr.forEach(function(current,index,array){
              current.value ="";
          });
        },
      getDOMstring:function(){
          return DOMstrings;
      }
      
    };
})();

var controller = (function(budgetCtrl, UICtrl){
    var setupEventListeners = function(){
        var DOM = UICtrl.getDOMstring();
        document.querySelector(DOM.inputBtn).addEventListener('click',ctrlAddItem);
        document.addEventListener('keypress',function(event){
        
            if(event.keycode === 13){
                console.log('ENTER was pressed');
                ctrlAddItem();
            }
        });
    };
    
    
    var ctrlAddItem = function(){
        var input,newItem;
        // 1. Get the field input data
        input = UICtrl.getInput();
        console.log(input);
        //2. Add the item to the budget controller
        newItem = budgetCtrl.addItem(input.type,input.description,input.value);
        
        //3. Add the item to the UI
        UICtrl.addListItems(newItem,input.type)
        //4. Clear the Fields
        UICtrl.clearFields();
        //4. Calculate the budget
        //5. Display the budget on the UI
        console.log("It works");
    };
    
    return{
        init:function(){
            console.log('Application has started.');
            setupEventListeners();
        }
    }
    
})(budgetController,UIController);

controller.init();