import React, { Component } from 'react';
import '../styles/QuestionTemplate.css';

export class QuestionTemplate extends Component {
    static displayName = QuestionTemplate.name;

    constructor(props) {
        super(props);
        this.state = { question: null, loading: true };
    }

    componentDidMount() {
        this.populateQuestionData();
    }

    static renderQuestionTable(question) {
        return (
            <form class="question-template-main-atr">
                <label>
                    Текст вопроса:
                <input type="text" name="name" defaultValue={question.name} />
                </label>
                <label>
                    Пояснения к заполнению:
                <input type="text" name="description" defaultValue={question.description} />
                </label>
                <input type="submit" value="Сохранить изменения" />
            </form>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : QuestionTemplate.renderQuestionTable(this.state.question);

        return (
            <div>
                <h1 id="tabelLabel" >Шаблон вопроса</h1>
                <p>Создание и редактирование шаблона вопроса теста.</p>
                {contents}
            </div>
        );
    }

    async populateQuestionData() {
        const response = await fetch('QuestionSettings');
        const data = await response.json();
        this.setState({ question: data, loading: false });
    }
}
