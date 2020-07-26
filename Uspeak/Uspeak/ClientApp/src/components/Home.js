import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    raiseInvoiceClicked() {
        window.open("www.google.com"); //to open new page
    }

  render () {
    return (
      <div>
        <h1>Пример стилей оформления сайта (Заголовок)</h1>
        <p>Параграф</p>
        <ul>
          <li><a href='https://get.asp.net/'>пример</a> ссылок</li>
        </ul>
        <p>Пример списка:</p>
        <ul>
          <li><strong>Навигация</strong>. Например, нажмите <em>счетчик</em> потом <em>Назад,</em> чтобы вернуться сюда.</li>
          <li><strong>Еще элемент списка</strong></li>
          <li><strong>Другой элемент списка</strong></li>
        </ul>
            <button type="button" className="btn btn-primary" onClick={this.raiseInvoiceClicked}>Начать урок</button>
      </div>
    );
  }
}
