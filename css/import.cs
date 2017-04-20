* {
  margin: 0;
  padding: 0;
}
html,
body {
  font-family: 'Open Sans', sans-serif;
  margin: 0;
  padding: 0;
  font-size: 15px;
  text-rendering: optimizeLegibility;
  width: 100%;
  height: 100%;
  overflow-x: hidden;
}
.bl {
  z-index: 99;
  position: fixed;
  width: 100%;
  height: 100%;
  left: 0;
  top: 0;
  background-color: rgba(0, 0, 0, 0.8);
}
a {
  text-decoration: none;
}
li {
  list-style: none;
}
.clearfix::after {
  content: "";
  display: block;
  clear: both;
}
.wrapper {
  max-width: 1500px;
  width: 100%;
  margin: 0 auto;
}
.alert {
  background-color: #000;
  width: 300px;
  height: 200px;
  top: 50%;
  position: absolute;
  left: 50%;
  transform: translate(-50%, -50%);
  z-index: 1000;
  animation: modalAnim 6s ease-in-out forwards;
}
@keyframes modalAnim {
  0% {
    transform: translate(-500%, -50%) rotate(-90deg);
    opacity: 0;
  }
  15%,
  85% {
    transform: translate(-50%, -50%);
    opacity: 1;
  }
  100% {
    transform: translate(500%, -50%) rotate(90deg);
    opacity: 0;
  }
}
header {
  width: 100%;
  height: 50px;
  background-color: #13458c;
}
header button {
  display: inline-block;
  background: none;
  border: none;
  display: none;
}
header button span.mobile-menu {
  background-image: url(../image/menu.png);
  background-repeat: no-repeat;
  display: inline-block;
  width: 20px;
  height: 20px;
  margin-top: 15px;
  margin-left: 12px;
  background-size: cover;
}
header button:focus {
  outline: none;
}
header .search {
  width: 500px;
  height: 20px;
  line-height: 20px;
  margin: 0 auto;
  text-align: center;
  background-color: #fff;
}
header .search i {
  color: #ccc;
  font-size: 130%;
}
header .search span {
  color: #ccc;
  font-size: 90%;
  vertical-align: 4px;
  padding-left: 7px;
}
header .top-btn {
  float: right;
}
header .top-btn .btn {
  display: inline-block;
  padding: 5px 15px;
  background-color: #60C9FF;
  border-radius: 200px;
  text-decoration: none;
  color: #fff;
  font-size: 70%;
  text-transform: uppercase;
  margin-top: 11.5px;
}
header .top-btn .logout {
  background-color: #0d2f5f;
}
nav {
  float: left;
  width: 13.333%;
  height: 950px;
  background-color: #314048;
}
nav button {
  background: none;
  border: none;
  padding-left: 10px;
  padding-top: 10px;
  text-align: right;
  display: none;
}
nav button:focus {
  outline: none;
}
nav ul {
  margin: 0 auto;
  height: 100%;
}
nav ul li {
  width: auto;
  padding: 15px 0;
  padding-left: 45px;
}
nav ul li a {
  font-size: 85%;
  color: #d3d3d3;
  text-transform: uppercase;
  letter-spacing: 1px;
  font-weight: 600;
}
nav ul i {
  font-size: 95%;
  color: #d3d3d3;
  padding-right: 5px;
}
nav li:hover {
  background-color: #1c252a;
}
nav li:hover a {
  color: #fff;
}
nav li:hover i {
  color: #fff;
}
nav li:first-child a {
  text-transform: capitalize;
  font-size: 105%;
}
nav li:first-child i {
  font-size: 105%;
}
.main-contents {
  width: 60%;
  float: left;
}
.main-contents h2 {
  margin-top: 20px;
  text-transform: uppercase;
  font-weight: 600;
  text-align: center;
  font-size: 115%;
  position: relative;
}
.main-contents h2 button.chart-button {
  background: none;
  border: none;
  display: inline-block;
  position: absolute;
  top: 10%;
  left: 90%;
  display: none;
}
.main-contents h2 button.chart-button:focus {
  outline: none;
}
.main-contents h2 button.chart-button span {
  width: 32px;
  height: 32px;
  display: inline-block;
  background-image: url(../image/pie-chart.png);
  background-size: cover;
  background-repeat: no-repeat;
}
.main-contents .date {
  margin-top: 10px;
}
.main-contents .date .select_date {
  text-align: center;
}
.main-contents .date .select_date i {
  font-size: 130%;
  vertical-align: -4px;
  padding-right: 7px;
}
.main-contents .date .select_date span {
  font-size: 100%;
  vertical-align: middle;
}
.main-contents .date_bar {
  width: 100%;
  background-color: #c9ddf5;
  height: 30px;
  margin-top: 10px;
  position: relative;
  z-index: 1;
}
.main-contents .date_bar ul li {
  display: inline-block;
  color: #fff;
  line-height: 30px;
  padding-left: 40px;
  font-size: 85%;
}
.main-contents .date_bar ul li i {
  color: #fff;
}
.main-contents .expense_icon_collection ul {
  margin-top: 10px;
  text-align: center;
}
.main-contents .expense_icon_collection ul li {
  display: inline-block;
  padding: 0 10px;
  margin: 0 30px;
}
.main-contents .expense_icon_collection ul li .icon {
  display: inline-block;
  background-repeat: no-repeat;
  background-position: center 2px;
  background-size: contain;
  width: 40px;
  height: 40px;
}
.main-contents .expense_icon_collection ul li .eati {
  background-image: url(../image/eat_change.png);
  width: 50px;
  height: 50px;
}
.main-contents .expense_icon_collection ul li .takei {
  background-image: url(../image/take.png);
}
.main-contents .expense_icon_collection ul li .seei {
  background-image: url(../image/see.png);
}
.main-contents .expense_icon_collection ul li .shopi {
  background-image: url(../image/shop.png);
}
.main-contents .expense_icon_collection ul li .sleepi {
  background-image: url(../image/sleep.png);
}
.main-contents .expense_icon_collection ul li .etci {
  background-image: url(../image/etc.png);
}
.main-contents .expense_icon_collection ul li .description {
  display: block;
  width: 100%;
  text-align: center;
  text-transform: capitalize;
  color: #c4c4c4;
  font-weight: 600;
  position: relative;
  top: -2px;
}
.main-contents .expense_icon_collection ul li.on {
  border: 4px #c9dbf2 solid;
  border-radius: 10px;
}
.main-contents .expense_icon_collection ul li.on .description {
  color: #000;
}
.main-contents .container .expenses__list {
  margin-top: 15px;
  float: left;
  width: 48.88%;
  height: 450px;
  background-color: #edf0f2;
  padding: 20px 60px;
  font-size: 120%;
  overflow-y: scroll;
  position: relative;
}
.main-contents .container .expenses__list button.add {
  display: inline-block;
  position: absolute;
  top: 80%;
  left: 50%;
  transform: translateX(-50%);
  background: none;
  border: none;
  display: none;
}
.main-contents .container .expenses__list button.add span {
  background-image: url(../image/add.png);
  display: inline-block;
  width: 55px;
  height: 55px;
  border: none;
  background-repeat: no-repeat;
  background-size: cover;
}
.main-contents .container .expenses__list button.add:focus {
  outline: none;
}
.main-contents .container .expenses__list .item {
  margin-top: 15px;
}
.main-contents .container .expenses__list .item img {
  width: 26px;
  height: 26px;
  float: left;
  padding-right: 15px;
}
.main-contents .container .expenses__list .item .item_description {
  float: left;
}
.main-contents .container .expenses__list .item .right {
  float: right;
}
.main-contents .container .expenses__list .item .right .item__value {
  float: left;
  transition: transform 0.3s;
  color: #000;
}
.main-contents .container .expenses__list .item .right .item__delete {
  float: left;
}
.main-contents .container .expenses__list .item .right .item__delete .item__delete--btn {
  font-size: 22px;
  background: none;
  border: none;
  cursor: pointer;
  display: inline-block;
  vertical-align: middle;
  line-height: 1;
  display: none;
}
.main-contents .container .expenses__list .item:hover .right .item__delete--btn {
  display: block;
  color: #2472e1;
}
.main-contents .container .expenses__list .item:hover .right .item__value {
  transform: translateX(-20px);
}
.main-contents .container .take {
  display: none;
}
.main-contents .container .see {
  display: none;
}
.main-contents .container .shop {
  display: none;
}
.main-contents .container .sleep {
  display: none;
}
.main-contents .container .etc {
  display: none;
}
.main-contents .container .calculator {
  background-color: #e5e5e5;
  width: 33.33%;
  max-width: 300px;
  height: 450px;
  float: right;
  margin-top: 15px;
  padding: 20px 10px;
  position: relative;
  z-index: 1;
}
.main-contents .container .calculator button.close {
  background: none;
  position: absolute;
  top: -50px;
  left: 320px;
  border: none;
  display: block;
  display: none;
}
.main-contents .container .calculator button.close span.close-button {
  width: 32px;
  height: 32px;
  display: inline-block;
  background-image: url(../image/close.png);
  background-repeat: no-repeat;
  background-size: cover;
}
.main-contents .container .calculator .select_icon {
  padding-bottom: 10px;
}
.main-contents .container .calculator .select_icon .add_type {
  float: left;
  font-family: inherit;
}
.main-contents .container .calculator .select_icon .right {
  float: right;
}
.main-contents .container .calculator .select_icon .right span {
  font-size: 70%;
  vertical-align: 2px;
}
.main-contents .container .calculator .calculate_value {
  width: 100%;
  height: 70px;
  background-color: #fff;
  text-align: center;
}
.main-contents .container .calculator .calculate_value #display {
  width: 100%;
  height: 70px;
  background-color: #fff;
  text-align: left;
  text-indent: 10px;
  font-family: inherit;
  font-size: 120%;
  border: none;
}
.main-contents .container .calculator .title {
  width: 100%;
  margin-top: 10px;
}
.main-contents .container .calculator .title input {
  width: 100%;
  height: 35px;
  background-color: #fff;
  border: none;
  font-family: inherit;
  font-size: 100%;
  text-align: center;
}
.main-contents .container .calculator .keys {
  width: 100%;
  border: 1px #d3d3d3 solid;
  margin-top: 10px;
  box-sizing: border-box;
  border-left: none;
  border-bottom: none;
}
.main-contents .container .calculator .keys button {
  font-size: 90%;
  float: left;
  width: 25%;
  height: 45px;
  line-height: 45px;
  text-align: center;
  display: inline-block;
  border-left: 1px #d3d3d3 solid;
  border-bottom: 1px #d3d3d3 solid;
  border-right: none;
  border-top: none;
  background: none;
  background-color: #fff;
}
.main-contents .container .calculator .keys button:focus {
  outline: none;
}
.main-contents .container .calculator .keys .clear {
  width: 37.5%;
}
.main-contents .container .calculator .keys .backspace {
  width: 37.5%;
}
.main-contents .container .calculator .keys .change_sign {
  width: 25%;
}
.main-contents .container .calculator .add__btn {
  width: 100%;
  height: 50px;
  background-color: #60C9FF;
  margin-top: 10px;
  text-align: center;
  line-height: 50px;
  font-size: 130%;
  border: none;
  display: block;
}
.main-contents .container .calculator .add__btn:focus {
  outline: none;
}
.main-contents .container .calculator .add__btn span {
  color: #fff;
  font-size: 85%;
  vertical-align: top;
}
.main-contents .container .calculator .add__btn i {
  font-weight: 400;
  color: #fff;
}
.main-contents .totalall__expenses {
  float: left;
  width: 100%;
  position: relative;
  z-index: 1;
  margin-top: 15px;
}
.main-contents .totalall__expenses .type .card__expenses {
  width: 50%;
  height: 50px;
  float: left;
  text-align: center;
  font-size: 130%;
}
.main-contents .totalall__expenses .type .card__expenses .right {
  width: 70px;
  margin: 0 auto;
}
.main-contents .totalall__expenses .type .card__expenses .right .equal {
  float: left;
}
.main-contents .totalall__expenses .type .card__expenses .right .card__expenses--value {
  float: right;
}
.main-contents .totalall__expenses .type .cash__expenses {
  float: right;
  width: 50%;
  height: 50px;
  text-align: center;
  font-size: 130%;
}
.main-contents .totalall__expenses .type .cash__expenses .right {
  width: 70px;
  margin: 0 auto;
}
.main-contents .totalall__expenses .type .cash__expenses .right .equal {
  float: left;
}
.main-contents .totalall__expenses .type .cash__expenses .right .cash__expenses--value {
  float: right;
}
.main-contents .totalall__expenses .type:after {
  display: block;
  content: "";
  clear: both;
}
.main-contents .totalall__expenses .total__expenses {
  margin-top: 15px;
  background-color: #73a7e5;
  width: 100%;
  height: 60px;
  text-align: center;
}
.main-contents .totalall__expenses .total__expenses .total_container {
  width: 220px;
  height: 100%;
  line-height: 60px;
  font-size: 160%;
  margin: 0 auto;
  padding-left: 40px;
  letter-spacing: 3px;
  color: #fff;
}
.main-contents .totalall__expenses .total__expenses .total_container .total__expenses--title {
  float: left;
  margin-right: 20px;
}
.main-contents .totalall__expenses .total__expenses .total_container .total__expenses--value {
  float: left;
}
.main-contents .takeTotal {
  display: none;
}
.main-contents .seeTotal {
  display: none;
}
.main-contents .shopTotal {
  display: none;
}
.main-contents .etcTotal {
  display: none;
}
.main-contents .sleepTotal {
  display: none;
}
.chart {
  float: left;
  width: 22%;
  height: 100%;
}
.chart .donut #donutchart {
  position: relative;
  left: -50px;
  height: 100%;
}
.chart .donut #donutchart rect {
  fill: rgba(255, 255, 255, 0);
}
.chart .donut .table {
  margin-left: 20px;
  width: 310px;
}
.chart .donut .table ul li {
  padding-bottom: 15px;
}
.chart .donut .table ul li .item {
  float: left;
  position: relative;
  z-index: 1;
  background-color: #fff;
  padding-right: 5px;
}
.chart .donut .table ul li .price {
  float: right;
  padding-right: 50px;
  position: relative;
  z-index: 1;
  background-color: #fff;
  padding-left: 5px;
}
.chart .donut .table ul li .line {
  display: block;
  clear: both;
  position: relative;
  border-top: 1px #ccc solid;
  top: -10px;
}
.chart .pie #piechart {
  position: relative;
  left: -50px;
}
.chart .pie #piechart rect {
  fill: rgba(255, 255, 255, 0);
}
.chart .pie .table2 {
  margin-left: 20px;
  width: 310px;
}
.chart .pie .table2 ul li {
  padding-bottom: 15px;
}
.chart .pie .table2 ul li .payment {
  float: left;
  position: relative;
  z-index: 1;
  background-color: #fff;
  padding-right: 5px;
}
.chart .pie .table2 ul li .using {
  float: right;
  padding-right: 50px;
  position: relative;
  z-index: 1;
  background-color: #fff;
  padding-left: 5px;
}
.chart .pie .table2 ul li .line {
  display: block;
  clear: both;
  position: relative;
  border-top: 1px #ccc solid;
  top: -10px;
}
.chart .pie .table2 ul li .travel__expenses--title {
  float: left;
  position: relative;
  z-index: 1;
  background-color: #fff;
  padding-right: 5px;
}
.chart .pie .table2 ul li .travel__expenses--value {
  float: right;
  padding-right: 50px;
  position: relative;
  z-index: 1;
  background-color: #fff;
  padding-left: 5px;
}
@media screen and (max-width: 1200px) {
  header button {
    display: inline-block;
  }
  nav {
    display: none;
    width: 200px;
  }
  nav ul li {
    width: 100%;
    padding-left: 0;
  }
  nav ul li a {
    display: inline-block;
  }
  nav ul li i {
    padding-left: 49px;
  }
  .wrapper {
    margin: 0 auto;
  }
  .wrapper .main-contents {
    width: 100%;
  }
  .wrapper .main-contents h2 button.chart-button {
    display: block;
  }
  .wrapper .main-contents .container .expenses__list {
    width: 100%;
    padding: 20px 0;
  }
  .wrapper .main-contents .container .expenses__list button.add {
    display: block;
  }
  .wrapper .main-contents .container .expenses__list .item {
    padding: 0 80px;
  }
  .wrapper .main-contents .container .calculator {
    float: none;
    clear: left;
    display: none;
    width: 300px;
  }
  .wrapper .chart {
    width: 100%;
    position: relative;
    top: 30px;
  }
  .wrapper .chart .donut #donutchart {
    position: absolute;
    top: 0;
    left: 0;
  }
  .wrapper .chart .donut .table {
    width: 50%;
    position: absolute;
    top: 35px;
    left: 40%;
  }
  .wrapper .chart .pie {
    position: relative;
    top: 320px;
  }
  .wrapper .chart .pie #piechart {
    position: absolute;
    top: 0;
    left: 0;
  }
  .wrapper .chart .pie .table2 {
    width: 50%;
    position: absolute;
    top: 90px;
    left: 40%;
  }
}
@media screen and (max-width: 992px) {
  .wrapper .chart .donut .table {
    width: 40%;
    left: 50%;
  }
  .wrapper .chart .pie .table2 {
    width: 40%;
    left: 50%;
  }
}
@media screen and (max-width: 768px) {
  .wrapper .chart .donut #donutchart {
    left: 56%;
    transform: translateX(-50%);
  }
  .wrapper .chart .donut .table {
    width: 100%;
    left: 0;
    top: 310px;
  }
  .wrapper .chart .pie {
    top: 550px;
  }
  .wrapper .chart .pie #piechart {
    left: 56%;
    transform: translateX(-50%);
  }
  .wrapper .chart .pie .table2 {
    top: 310px;
    width: 100%;
    left: 0;
  }
}
