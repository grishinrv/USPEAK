import React, { Component } from 'react';
import '../styles/QuestionTemplate.css';
import EdiText from 'react-editext'

export class QuestionTemplate extends Component {
    static displayName = QuestionTemplate.name;

    constructor(props) {
        super(props);
        this.state = { question: null, loading: true };
    }

    componentDidMount() {
        this.populateQuestionData();
    }

    onSave = val => {
        console.log('Edited Value -> ', val)
    }

    static renderQuestionTable(question) {
        return (
            <div class="question-template-main-atr">
                <label>
                    <b>Текст вопроса:</b>
                    <EdiText
                        type='text'
                        value={question.name}
                        onSave={this.onSave}
                    />
                </label>
                <label>
                    <b>Пояснения к заполнению:</b>
                    <EdiText
                        type='text'
                        value={question.description}
                    />
                </label>
                <button className="btn btn-primary" onClick={this.saveClicked}>Сохранить</button>
            </div>
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
        const response = await fetch('QuestionSettings/Create');
        const data = await response.json();
        this.setState({ question: data, loading: false });
    }
}
