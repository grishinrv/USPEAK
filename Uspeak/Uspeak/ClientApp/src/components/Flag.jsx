import React from 'react';
import {createUseStyles} from 'react-jss';

const classes = createUseStyles({
  eng: {
    background: {
      color: '#00247d',
      size: '100%'
    },
    position: 'relative',
    '&:before': {
      position: 'absolute',
      content: '""',
      top: 0,
      left: 0,
      background: 'linear-gradient(180deg,transparent 40%, #cc142b 0,#cc142b 60%,transparent 0),\n' +
        '  linear-gradient(90deg,transparent 45%,#cc142b 0,#cc142b 55%,transparent 0),\n' +
        '  linear-gradient(180deg,transparent 35%,#fff 0,#fff 65%,transparent 0),\n' +
        '  linear-gradient(90deg,transparent 40%,#fff 0,#fff 60%,transparent 0),\n' +
        '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -65% 45%,\n' +
        '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 55% -45%,\n' +
        '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -75% -43%,\n' +
        '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 70% 46%,\n' +
        '  linear-gradient(146deg,transparent 45%,#fff 0,#fff 55%,transparent 0),\n' +
        '  linear-gradient(34deg,transparent 45%,#fff 0,#fff 55%,transparent 0)',
      width: '100%',
      height: '100%',
      'background-repeat': 'no-repeat'
    }
  },
  de: {
    background: {
      color: '#000000',
      size: '100%'
    },
    position: 'relative',
    '&:before': {
      position: 'absolute',
      content: '""',
      top: 0,
      left: 0,
      background: 'linear-gradient(180deg,transparent 34%, #ff0000, 0, #ff0000 67%, transparent 0),\n' +
        'linear-gradient(180deg,transparent 67%, #ffd700, 0, #ffd700 100%, transparent 0)',
      width: '100%',
      height: '100%',
      'background-repeat': 'no-repeat'
    },
  },
  fr: {
    background: {
      color: '#0000ff',
      size: '100%'
    },
    position: 'relative',
    '&:before': {
      position: 'absolute',
      content: '""',
      top: 0,
      left: 0,
      background: 'linear-gradient(90deg,transparent 34%, #ffffff, 0, #ffffff 67%, transparent 0),\n' +
                  'linear-gradient(90deg,transparent 67%, #ff0000, 0, #ff0000 100%, transparent 0)',
      width: '100%',
      height: '100%',
      'background-repeat': 'no-repeat'
    },
  },
  it: {
    background: {
      color: '#228b22',
      size: '100%'
    },
    position: 'relative',
    '&:before': {
      position: 'absolute',
      content: '""',
      top: 0,
      left: 0,
      background: 'linear-gradient(90deg,transparent 34%, #ffffff, 0, #ffffff 67%, transparent 0),\n' +
                  'linear-gradient(90deg,transparent 67%, #ff0000, 0, #ff0000 100%, transparent 0)',
      width: '100%',
      height: '100%',
      'background-repeat': 'no-repeat'
    },
  },
  ch: {
    'background-color': '#de2910',
    position: 'relative'
  },
  star: {
    display: 'block',
    position: 'absolute',
    top: '15%',
    left: '-3%',
    width:0,
    height:0,
    'border-right':'50px solid transparent',
    'border-bottom':'35px solid #ffde00',
    'border-left':'50px solid transparent',
    '-moz-transform':'rotate(35deg) scale(0.45,.45)',
    '-webkit-transform':'rotate(35deg) scale(0.45,.45)',
    '-ms-transform':'rotate(35deg) scale(0.45,.45)',
    '-o-transform':'rotate(35deg) scale(0.45,.45)',
    '&:before': {
      content:'""',
      display:'block',
      position:'absolute',
      top:'-22.5px',
      left:'-32.5px',
      height:0,
      width:0,
      'border-bottom':'40px solid #ffde00',
      'border-left':'15px solid transparent',
      'border-right':'15px solid transparent',
      '-webkit-transform':'rotate(-35deg)',
      '-moz-transform':'rotate(-35deg)',
      '-ms-transform':'rotate(-35deg)',
      '-o-transform':'rotate(-35deg)'
    },
    '&:after': {
      content:'""',
      display:'block',
      position:'absolute',
      top:'3px',
      left:'-52.5px',
      width:0,
      height:0,
      'border-right':'50px solid transparent',
      'border-bottom':'35px solid #ffde00',
      'border-left':'50px solid transparent',
      '-webkit-transform':'rotate(-70deg)',
      '-moz-transform':'rotate(-70deg)',
      '-ms-transform':'rotate(-70deg)',
      '-o-transform':'rotate(-70deg)'
    }
  },
  starMain: {
    top:'19px',
    left:'-5px',
    '-moz-transform':'rotate(35deg) scale(0.45,.45)',
    '-webkit-transform':'rotate(35deg)	scale(0.45,.45)',
    '-ms-transform':'rotate(35deg) scale(0.45,.45)',
    '-o-transform':'rotate(35deg) scale(0.45,.45)'
  }
});

export default function Flag(country) {

}