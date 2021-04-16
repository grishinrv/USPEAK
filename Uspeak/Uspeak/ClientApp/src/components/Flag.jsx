import React from 'react';
import {createUseStyles} from 'react-jss';

const useStyles = createUseStyles({
  stdFlag :{
    width: '100%',
    height: '100%',
    'background-size':'100%',
    position: 'relative',
    '&:before': {
      position: 'absolute',
      content: '""',
      top: 0,
      left: 0,
      width: '100%',
      height: '100%',
      'background-repeat': 'no-repeat'
    }
  },
  eng: {
    'background-color':'#00247d',
    '&:before': {
      background: 'linear-gradient(180deg,transparent 40%, #cc142b 0,#cc142b 60%,transparent 0),\n' +
        '  linear-gradient(90deg,transparent 45%,#cc142b 0,#cc142b 55%,transparent 0),\n' +
        '  linear-gradient(180deg,transparent 35%,#fff 0,#fff 65%,transparent 0),\n' +
        '  linear-gradient(90deg,transparent 40%,#fff 0,#fff 60%,transparent 0),\n' +
        '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -65% 45%,\n' +
        '  linear-gradient(146deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 55% -45%,\n' +
        '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) -75% -43%,\n' +
        '  linear-gradient(34deg,transparent 50%,#cc142b 0,#cc142b 53%,transparent 0) 70% 46%,\n' +
        '  linear-gradient(146deg,transparent 45%,#fff 0,#fff 55%,transparent 0),\n' +
        '  linear-gradient(34deg,transparent 45%,#fff 0,#fff 55%,transparent 0)'
    }
  },
  de: {
    'background-color':'#000000',
    '&:before': {
      background: 'linear-gradient(180deg,transparent 34%, #ff0000, 0, #ff0000 67%, transparent 0),\n' +
        'linear-gradient(180deg,transparent 67%, #ffd700, 0, #ffd700 100%, transparent 0)'
    },
  },
  fr: {
    'background-color':'#0000ff',
    '&:before': {
      background: 'linear-gradient(90deg,transparent 34%, #ffffff, 0, #ffffff 67%, transparent 0),\n' +
        'linear-gradient(90deg,transparent 67%, #ff0000, 0, #ff0000 100%, transparent 0)'
    },
  },
  it: {
    'background-color':'#228b22',
    '&:before': {
      background: 'linear-gradient(90deg,transparent 34%, #ffffff, 0, #ffffff 67%, transparent 0),\n' +
        'linear-gradient(90deg,transparent 67%, #ff0000, 0, #ff0000 100%, transparent 0)'
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
  },
  math: {
    'background-color':'#def',
    'background-image': 'radial-gradient(closest-side, transparent 98%, rgba(0,0,0,.3) 99%),\n' +
    'radial-gradient(closest-side, transparent 98%, rgba(0,0,0,.3) 99%)',
    'background-size':'80px 80px',
    'background-position':'0 0, 40px 40px'
  },
  physics:{
    background: 'radial-gradient(circle at 100% 50%, transparent 20%, rgba(255,255,255,.3) 21%, rgba(255,255,255,.3) 34%, transparent 35%, transparent),\n' +
                'radial-gradient(circle at 0% 50%, transparent 20%, rgba(255,255,255,.3) 21%, rgba(255,255,255,.3) 34%, transparent 35%, transparent) 0 -50px',
    'background-color':'slategray',
    'background-size':'75px 100px'
  },
  ru: {
    'background-color':'#ffffff',
    '&:before': {
      background: 'linear-gradient(180deg,transparent 34%, #ff0000, 0, #0BB5FF 67%, transparent 0),\n' +
        'linear-gradient(180deg,transparent 67%, #ffd700, 0, #FF0000 100%, transparent 0)'
    },
  },
  evo: {
    'background-image': 'radial-gradient(closest-side, transparent 0%, transparent 75%, #B6CC66 76%, #B6CC66 85%, #EDFFDB 86%, #EDFFDB 94%, #FFFFFF 95%, #FFFFFF 103%, #D9E6A7 104%, #D9E6A7 112%, #798B3C 113%, #798B3C 121%, #FFFFFF 122%, #FFFFFF 130%, #E0EAD7 131%, #E0EAD7 140%),\n' +
                        'radial-gradient(closest-side, transparent 0%, transparent 75%, #B6CC66 76%, #B6CC66 85%, #EDFFDB 86%, #EDFFDB 94%, #FFFFFF 95%, #FFFFFF 103%, #D9E6A7 104%, #D9E6A7 112%, #798B3C 113%, #798B3C 121%, #FFFFFF 122%, #FFFFFF 130%, #E0EAD7 131%, #E0EAD7 140%)',
    'background-color': '#C8D3A7',
    'background-position': '0 0, 0, 0'
  }
});

export default function Flag(props) {
  const classes = useStyles();
  const classesMap = {
    'eng': [classes.stdFlag, classes.eng].join(" "),
    'de': [classes.stdFlag, classes.de].join(" "),
    'fr': [classes.stdFlag, classes.fr].join(" "),
    'it': [classes.stdFlag, classes.it].join(" "),
    'ch': [classes.stdFlag, classes.ch].join(" "),
    'math': [classes.stdFlag, classes.math].join(" "),
    'physics': [classes.stdFlag, classes.physics].join(" "),
    'ru': [classes.stdFlag, classes.ru].join(" "),
    'evo': [classes.stdFlag, classes.evo].join(" ")
  }

  function getTemplate(subjectCssClass)
  {
    if (subjectCssClass === 'ch')
    {
      return (
        <div className={classesMap[subjectCssClass]}>
          <div className={[classes.star, classes.starMain].join(" ")}/>
          {props.children}
        </div>
      );
    }
    else
    {
      return (
        <div className={classesMap[subjectCssClass]}>
          {props.children}
        </div>
      );
    }
  }

  return ( getTemplate(props.cssClass) );
}